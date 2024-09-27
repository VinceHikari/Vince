/* Vincent Marshall - 300714991 - VincentMarshallPortfolio - Sept 26, 2024*/

import project1 from '../src/assets/prjct1.png';
import project2 from '../src/assets/prjct2.png';
import project3 from '../src/assets/prjct3.png';
import project4 from '../src/assets/prjct4.png';
import project5 from '../src/assets/prjct5.png';

import { Link } from 'react-router-dom';
import '../src/index.css'
import '../src/project.css'
export default function Project() {
     return <>
     
     <section id="works">
         
          <h2 className="worksTitle">My Projects</h2>
          <span className="worksDesc">I take pride in paying attention to the smallest details and making sure my work is pixel perfect/ 
          I am excited to bring my skills and experience to help businesses achieve their goals and create a strong online presence.</span> 
          <div className="worksImgs">

          <p className ="desc">College Feedback form</p>
          <img src={project1} alt="project1" className="worksImg" /> 
          <p class = "shortdesc">Created a feedback form for my college courses. Good resource for teachers.</p>
          <p className ="desc">Real Estate webpage</p>
          <img src={project2} alt="project2" className="worksImg" />
          <p class = "shortdesc">Created a Real Estate website highlighting properties for sale. Made for Real Estate agents with user focus in mind.</p> 
          <p className ="desc">Contact Us Form</p>
          <img src={project3} alt="project3" className="worksImg" />
          <p class = "shortdesc">Created a generic contact form with a clean UI and very user friendly. Contains functional dropdown fields.</p>
          <p className ="desc">Interactive Slideshow</p>
          <img src={project4} alt="project4" className="worksImg" />
          <p class = "shortdesc">Created a interactive slideshow with JavaScript. User can click through photos or let the slideshow automatically scroll.</p>
          <p className ="desc">Banking App</p>
          <img src={project5} alt="project5" className="worksImg" /> 
          <p class = "shortdesc">Created a simple banking app using C# in Visual Studio. User can withdraw and deposit amount, with daily limits.</p>
                  
                  
               
               </div>

         
                  
                  
     </section>
    

     </>
    }
    