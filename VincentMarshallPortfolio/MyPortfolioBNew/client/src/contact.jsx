/* Vincent Marshall - 300714991 - VincentMarshallPortfolio - Sept 26, 2024*/

import '../src/contact.css'
export default function Contact() {
     return (
     <>
     <p>Contact</p>
     <form id="ffp">
		
			
				<label htmlFor="myFName"> First Name: </label>
				<input type="text" id="myFName" name="myFName" required="required" autoFocus /> <br /> <br />
				
				<label htmlFor="myLName"> Last Name: </label>
				<input type="text" id="myLName" name="myLName" required="required" /> <br /> <br />
				
				
				<label htmlFor="myEmail"> Email: </label>
				<input type="email" id="myEmail" name="myEmail" required="required" /> <br /> <br />
				
				<input type="submit" className="submit" value="Submit" /> <br />
					
		
		</form> <br></br>
          <p className= 'contactMe'><strong>More ways to contact me below!</strong></p>
 <p><a href="www.linkedin.com/in/vincentjamesmarshall"> LinkedIn </a></p>
 <p>Phone: 647-512-59xx</p>
 <a href="mailto:vincentjamesmarshall?subject=Subject&body=message%20goes%20here">Email</a>
     </>
     );
     }
    