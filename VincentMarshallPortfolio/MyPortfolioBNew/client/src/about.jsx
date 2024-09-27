/* Vincent Marshall - 300714991 - VincentMarshallPortfolio - Sept 26, 2024*/
import JS from '../src/assets/jslogo.png';
import sql from '../src/assets/SQLlogo.jpg';
import react from '../src/assets/reactlogo.png';
import hire from '../src/assets/hire.jpg';
import { Link } from 'react-router-dom';
import '../src/index.css'
import '../src/about.css'
export default function About() {
     return <>
     
     <section id="skill">
         
          <span className="skillTitle">Vincent J. Marshall</span>
          <br></br>
          <span className="skillDesc">I am currently a Software Engineering Technology student at Centennial College and I am pursuing a career in Software Development. I am passionate about coding and working with computers. I have a strong understanding of web design. I have taken courses in HTML, CSS, JavaScript, React, Node, Java, C# and more. I plan to continously learn to hone my skills and become a better programmer everyday.</span> 
          <div className="skillBar">
               <img src={JS} alt="UIDesign" className="skillBarImg" />
               <div className="skillBarText">
               <h2>JavaScript</h2>
               <p></p>
               </div>

          </div>
          
          <div className="skillBar">
               <img src={sql} alt="WebDesign" className="skillBarImg" />
               <div className="skillBarText">
               <h2>SQL</h2>
               
               </div>

          </div>

          <div className="skillBar">
               <img src={react} alt="AppDesign" className="skillBarImg" />
               <div className="skillBarText">
               <h2>React</h2>
               <p></p>
               </div>

          </div>

          <div className= "resumeblock">
               <br></br>
               <a href="https://drive.google.com/file/d/1ZuaZqNyJsbyzYZS7ySKHyscf5AQJjUXb/view?usp=sharing" className="resume">Check out my Resume</a>
          </div>
          
                  
     </section>
    

     </>
    }
    