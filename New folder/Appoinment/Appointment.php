<?php 

require_once 'database.php';
if(isset($_POST['submit'])){
	  
	$name = $_POST['name'];
    $pno= $_POST['pno'];
	$email = $_POST['email'];
    $date = $_POST['date'];
    $cname = $_POST['cname'];
	
		
	
$conn = new mysqli('localhost','root','','hospital');
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}     
	$sql= "INSERT INTO `customer`( `Patient_Name`, `Contact_Number`, `customer_email`, `Issue_Date`,`Consultant_Name` ) VALUES ('$name','$pno','$email','$date','$cname')";

	
	 
	if ($conn->query($sql) === TRUE) {

     
	 echo '<script>alert(" Succesfuly Book Appoinment !...")</script>'; 
	
     header("Location:hospital.html");
  
     
  
			 
  
}else{
	
	echo '<script>alert("Not Succesfuly  Book Appoinment !...")</script>'; 
	
}

$conn->close();

}



?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="assets/css/bootstrap.min.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <link rel="stylesheet" href="Appointment.css">
    
   
    <title>Document</title>
</head>
<body>
    
        
            <nav class="navbar navbar-light" style="background-color: #78997d;">
                <!-- Navbar content -->
              </nav>
            <section id="header">
                <nav>
                    <a href="https://www.nibmworldwide.com/"><img src="Logo.png"></a>
                    <div id="nav-links">
                        <ul>
                            
                         <li><a href="Hospital.html">HOME</a></li>
                         <li><a href="Aboutus.html">ABOUT</a></li>
                         <li><a href="login.php">BOOK APPOINTMENT</a></li>
                         <li><a href="">view Appoinment</a></li>
                        </ul>
         
                    </div>
                </nav>
        
         
            </section>
        
        
        
       <form action="" method="post">
            <div class="inner-layer">
                <div class="container">
                  <div class="row no margin">
                      <div class="col-sm-6">
                          <div class="content">
                            <h1>Book you Slot Now And Save Your Time</h1><br>
                            <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum</p>
        
                          </div>
                      </div>
                      <div class="col-sm-6">
                         <div class="form-data">
                             <div class="form-head">
                                <h4>Book Appointment</h4>
                             </div>
                             <div class="form-body">
                                <div class="row form-row " >
                                    <input type="text" placeholder="Enter Name" name="name" id="fn" class="form-control success" required>
                                  
                                </div>
        
                                <div class="row form-row error">
                                    <input type="text"  id="mb" placeholder="Enter mobile number" name="pno" class="form-control"required>
                                   
                                </div>
        
                                <div class="row form-row">
                                    <input type="email" placeholder="Enter Email address" id="ea" name="email" class="form-control"required>
                                   
                                </div>
        
                                <div class="row form-row">
                                    <input type="date" placeholder="Appointment Date" name="date" id="date" class="form-control"required>
                                   
                                </div>
                                <div class="row form-row " >
                                   
                                  <select name="cname">
                                      <option>Select Consultant Name</option>
                                      <option>hhhhh</option>
                                      <option>hgggggggg</option>
                                      <option>hhhhh</option>
                                      
                                  </select>
                                </div>
                              
        
                                
                                 </div><br>
        
                                 <div class="row form-row">
                                  <button class="btn-success btn-appointment" id="bk" name="submit" onclick="validate ()">
                                     Book Appointment
                                  </button>

                                 
        
        
        
                                     
                                 </div>
        
                             </div>
                         </div>
                      </div>
                  </div>  
                </div>
                
            </div>
        
          
        
        
        </form>

        <script>
            function validate ()
            {
                var a= document.getElementById("fn").value;
                var b= document.getElementById("mb").value;
                var c= document.getElementById("ea").value;
                var c= document.getElementById("ea").value;
                var d= document.getElementById("date").value;
                var e= document.getElementById("area").value;
                var f= document.getElementById("city").value;
                var g= document.getElementById("state").value;
                var h= document.getElementById("pc").value;
               



                if(a=="")
                {
                    alert("Please fill the name");
                    return false;
                }
                if(b=="")
                {
                    alert("Please fill the mobile number");
                    return false;  
                }
                if(isNaN(b))
                {
                    alert("Please enter only the numbers when the mobile number is entered");
                }
               if(b.length<10)
                {
                    alert("Invalid Mobile Number");
                    return false;
                }
                if(c =="")
                {
                    alert("Please enter Email address");
                }
                if(d =="")
                {
                    alert("Please enter Appointment date");
                }
                if(e =="")
                {
                    alert("Please enter Distric");
                }
                if(f =="")
                {
                    alert("Please enter City");
                }
                if(g =="")
                {
                    alert("Please enter State");
                }
                if(h =="")
                {
                    alert("Please enter Postal code");
                }
              


              

                
            }
        </script>

      




 


    






    <script src="assets/js/jquery-3.3.3.min.js"></script>
    <script src="assets/js/popper.min.js"></script>
    <script src="assets/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    
</body>
</html>