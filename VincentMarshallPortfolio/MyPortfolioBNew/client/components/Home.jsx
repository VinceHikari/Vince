/* Vincent Marshall - 300714991 - VincentMarshallPortfolio - Sept 26, 2024*/

import profile from '../src/assets/profile.jpeg';


import '../src/index.css'


export default function Home() {
     return <>
     
     <section id="intro">
          <div className="introContent">
          <a href="../src/assets/about.jsx" className ="hello">Welcome to my page!</a>
          <br></br>
          <br></br>
          <img src={profile} alt="profile" className="bbg" width="750" height="750"/>
          <br/>
          <p className="name">Vincent Marshall</p>
          <p className="occupation">Junior Software Developer</p>
          <p className="mission1">My mission is to create the cleanest and most functional code to the best of my ability. </p>
          <p className="mission2">I aim to help the project succeed expectations and I strive to provide excellence.</p>
          <a href="..src/assets/contact.jsx/"><img src="../src/assets/hire.jpg"></img></a>
         
          
          </div>
     
     </section>
    

     </>
     }
    