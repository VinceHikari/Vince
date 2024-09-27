var currentIndex = 0;
var imagesList = []; //declaring variable to use in function later
var timerId;

//Calling function
loadImageList();

// Previous button
document.getElementById('previousBtn').addEventListener('click', function() {
    clearTimeout(timerId);
    displayPreviousImage();
});

//  Next button
document.getElementById('nextBtn').addEventListener('click', function() {
    clearTimeout(timerId);
    displayNextImage();
});

// Update button
document.getElementById('updateBtn').addEventListener('click', function() {
    location.reload();
    
});

//Grab list of images from json list
function loadImageList() {
    var xhr = new XMLHttpRequest();
    xhr.open('GET', 'gallery.json', true);
    xhr.onreadystatechange = function() {
        if (xhr.readyState === XMLHttpRequest.DONE) {
            if (xhr.status === 200) {
                imagesList = JSON.parse(xhr.responseText);
                displayImage();
            } else {
                console.error('Failed to load image list:', xhr.statusText);
            }
        }
    };
    xhr.send();
}

//display the images in container
function displayImage() {
    var currentImage = document.getElementById('currentImage');
    currentImage.src = imagesList[currentIndex].filename;
    
    timerId = setTimeout(displayNextImage, imagesList[currentIndex].duration);
}

//previous image function
function displayPreviousImage() {
    currentIndex = (currentIndex === 0) ? imagesList.length - 1 : currentIndex - 1;
    displayImage();
}

//next image function
function displayNextImage() {
    currentIndex = (currentIndex === imagesList.length - 1) ? 0 : currentIndex + 1;
    displayImage();
}
 
