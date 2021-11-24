<?php
require_once 'database.php';
?>


<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link rel="stylesheet" href="hospital.css">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css">

    <style>
        #customers {
          font-family: Arial, Helvetica, sans-serif;
          border-collapse: collapse;
          width: 100%;
        }
        
        #customers td, #customers th {
          border: 1px solid #ddd;
          padding: 8px;
        }
        
        #customers tr:nth-child(even){background-color: #f2f2f2;}
        
        #customers tr:hover {background-color: #ddd;}
        
        #customers th {
          padding-top: 12px;
          padding-bottom: 12px;
          text-align: left;
          background-color: #04AA6D;
          color: white;
        }
        </style>
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
                    
                 <li><a href="hospital.html">HOME</a></li>
                 <li><a href="https://www.lankahospitals.com/">ABOUT</a></li>
                 <li><a href="login.php">BOOK APPOINTMENT</a></li>
                 
                </ul>
 
            </div>
        </nav>


<!-- gallery section starts  -->

<section class="Xray-menu">
        <div class="container">
            <h2 class="text-left">Report Menu</h2>
			
			<?php
			   
			   $search = $_POST['search'];
			   
			   $sql = "select * from out_patient_report where Patient_Id_Number LIKE '%$search%'";
			   
			   $res = mysqli_query($conn,$sql);
			   
			   $count = mysqli_num_rows($res);
			   
			   if($count>0)
			   {
				   while($row=mysqli_fetch_assoc($res))
				   {

					   $Patient_Id_Number = $row['Patient_Id_Number'];
                      
					   $Report = $row['Report'];
					   
					  
		     ?>
					   
					    <div class="drug-menu-box">
                <div class="drug-menu">
				
				
                  </div>

                     <div class="Patient_Id_Number"> <b><br> Patient ID Number</br> </b>
                    <?php echo $Patient_Id_Number; ?>
                    
                    <br>

                     <?php echo '<img src="data:image;base64,'.base64_encode($row['Report']).'" alt="Image" style="width: 500px; height: 500px;">' ;?> 

    
                       
                    
                   
                  </div>
                 </div>
			
		       <?php
				   }
				   
			   }else{
				   
				   echo"<div class='error'>Report NOT FOUND</div>";
				   
			   }
			
			
			?>
            <br>

            


            <div class="clearfix"></div>

            

        </div>

    </section>

<!-- gallery section ends -->

     <!-- Fotter -->
   <section>
    <footer class="footer">
        <div class="container">
            <div class="row">
                <div class="footer-col">
                    <h4>Hospital</h4>
                    <ul>
                       
                        <li><a href="Room.php">Room </a></li>
                        <li><a href="doctor.php">Doctor</a></li>
                        <li><a href="#">privacy policy</a></li>
                        
                    </ul>
                </div>
                <div class="footer-col">
                    <h4>Contact Us</h4>
                    <ul>
                        <li><a href="#">0761285178</a></li>
                        <li><a href="#">Bkaannthana@gmail.com</a></li>
                      
                    </ul>
                </div>
                <div class="footer-col">
                    <h4>view details</h4>
                    <ul>
                        
                        <li><a href="view.php">Appoinment</a></li>
                        <li><a href="galery.php">Drug</a></li>
                        <li><a href="in_out xray.php">X-Ray</a></li>
                        <li><a href="in_out report.php">Report</a></li>
                    </ul>
                </div>
                <div class="footer-col">
                    <h4>follow us</h4>
                    <div class="social-links">
                    <ul>
                        
                        <a href="#"><i class="fab fa-facebook-f"></i></a>
                        <a href="#"><i class="fab fa-twitter"></i></a>
                        <a href="#"><i class="fab fa-instagram"></i></a>
                        <a href="#"><i class="fab fa-linkedin-in"></i></a>
                    </ul>
                </div>
            </div>
        </div>
   </footer> 

</section>
       
    

   
    <script src="main.js"></script>
    
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.7/js/bootstrap.min.js"></script>

   

      

</body>

</html>