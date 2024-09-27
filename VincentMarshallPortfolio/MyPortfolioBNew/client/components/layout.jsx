/* Vincent Marshall - 300714991 - VincentMarshallPortfolio - Sept 26, 2024*/

import React from 'react';
import { Link } from 'react-router-dom';
import twitch from '../src/assets/twitch.png';
export default function Layout() {
 return (
 <>
 <br></br>
 < img src={twitch}alt="vincehasdat" className="twitch" width="200px" height="200px"/>
 <h1>Vincent Marshall</h1>
 
 <nav>
    
 <Link to="/">Home</Link> | <Link to="/about">About</Link> | <Link to="/services">Services</Link>| <Link to="/project">Projects</Link>| <Link to="/contact">Contact</Link>
 </nav>
<br/>
 <hr />
 
 </>
 
 );
}
