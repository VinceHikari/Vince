//what is bugReady and bgReady?
// how does the var bug {} work?
// how does const dist = Math.sqrt((mouseX - bug.x) ** 2 + (mouseY - bug.y) ** 2); work?



//Create the canvas
var canvas = document.createElement("canvas");
var ctx = canvas.getContext("2d");
canvas.width = 704;
canvas.height = 320;

canvas.style ="border:4px solid white";
document.body.appendChild(canvas);

//Background image
var bgReady = false;
var bgImage = new Image();
bgImage.onload = function () {
    bgReady = true;
};
bgImage.src = "imgs/pic1.png";


//Bug image
var bugReady = false;
var bugImage = new Image();
bugImage.onload = function () {
    bugReady = true;
};
bugImage.src = "imgs/bug3.png";

//Game objects
var bug = {};
var bugCaught = 0;
var intervalTime = 3000;

//Bug appearing and moving on screen
function spawnBug () {
    bug.x = (Math.random() * canvas.width); //generates random number on x axis along the width of the canvas
    bug.y = (Math.random() * canvas.height); 
}
spawnBug();

var reset = setInterval(function() {spawnBug()}, intervalTime); //resets position during intervals


//What happens when bug is clicked
canvas.addEventListener("mousedown", click, false)
function click(e) {
    e.preventDefault();
    //Mouse location when clicked
    mouseXinCanvas = e.clientX;
    mouseYinCanvas = e.clientY;
    //Compare clicked mouse location with the bug location
    if(mouseXinCanvas > bug.x 
        && mouseXinCanvas < bug.x + 50
        && mouseYinCanvas > bug.y 
        && mouseYinCanvas < bug.y + 170){
    
            //Add score when bug is clicked
            bugCaught++;
            //Increase the speed of the bug
            clearInterval(reset);
            intervalTime -= 500;
            //Update the time everytime bug is clicked
            reset = setInterval(function() {spawnBug()}, intervalTime);
            //Set limit for intervalTime
            if(intervalTime < 500){
                window.alert("You win! All the bugs are dead now!");
                //Reset interval when limit is hit
                resetScore();
            }
    }
}

//Reset speed function
function resetSpeed (){
    clearInterval(reset);
    intervalTime = 3000;
    spawnBug();
    reset = setInterval(function() {spawnBug()}, intervalTime);
}

//Add reset speed function to Reset Speed Button
let resetSpeedBut = document.getElementById("resetSpeedBut");
resetSpeedBut.onclick = resetSpeed;

//Reset Score
function resetScore() {
    bugCaught = 0;
    resetSpeed();
}

//Add reset score function to Reset Score Button
let resetScoreBut = document.getElementById("resetScoreBut");
resetScoreBut.onlick = resetScore;

//Draw everything
function render(){
    if(bgReady){
        ctx.drawImage(bgImage, 0, 0);
    }

    if(bugReady){
        ctx.drawImage(bugImage, bug.x, bug.y);
    }

    //Display the score
    ctx.fillStyle = "rgb(250, 250, 250)";
    
    ctx.font = "24px Helvetica";
    ctx.textAlign = "left";
    ctx.textBaseline = "top";
    ctx.fillText("Bugs Smashed: " + bugCaught, 30, 30);
}

// The main game loop
function main () {
    render();
    // Request to do this again ASAP
    requestAnimationFrame(main);
};

// Cross-browser support for requestAnimationFrame
var w = window;
requestAnimationFrame = w.requestAnimationFrame || w.webkitRequestAnimationFrame || w.msRequestAnimationFrame || w.mozRequestAnimationFrame;

// Let's play this game!
main();