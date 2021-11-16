

<!DOCTYPE html>
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
            <a href="https://www.nibmworldwide.com/"><img src="HEALTH_CARE_HOSPITAL__1_-removebg-preview (1).png"></a>
            <div id="nav-links">
                <ul>
                    
                 <li><a href="hospital.html">HOME</a></li>
                 <li><a href="https://www.lankahospitals.com/">ABOUT</a></li>
                 <li><a href="login.php">BOOK APPOINTMENT</a></li>
                 
                </ul>
 
            </div>
        </nav>
       
 
    
<html>
<head>
<style>
th, td {
  border-style:solid;
  border-color: #96D4D4;
  text-align:center;
}

table.center {
  margin-left: auto; 
  margin-right: auto;
}
</style>
<title>Display all records from Database</title>
</head>
<body>
<br>
<h2> <pre>                                 Hospital Doctor </pre></h2>
<br />

<table class="center"> 
  <tr>
    <td><b>specialist doctor Name</b> </td>
    <td><b>	Doctor Type</b></td>
    <td><b> doctor Field</td>
    <td><b> ward</td>
    <td><b> </td>
   
  </tr>

<?php

include "database.php"; // Using database connection file here

$records = mysqli_query($conn,"select * from specialist_doctor"); // fetch data from database

while($data = mysqli_fetch_array($records))
{
?>
  <tr>
    <td><?php echo $data['S_Doctor_Name']; ?></td>
    <td><?php echo $data['S_Doctor_Type']; ?></td>
    <td><?php echo $data['S_Field']; ?></td>
    <td><?php echo $data['Ward_Number'];?></td>
  </tr>	
<?php
}
?>
</table>

<?php mysqli_close($conn); // Close connection ?>
<br><br>
<!-- Fotter -->
<section>
    <footer class="footer">
        <div class="container">
            <div class="row">
                <div class="footer-col">
                    <h4>company</h4>
                    <ul>
                        <li><a href="index.html">about us</a></li>
                        <li><a href="#">our services</a></li>
                        <li><a href="#">privacy policy</a></li>
                        
                    </ul>
                </div>
                <div class="footer-col">
                    <h4>contact us</h4>
                    <ul>
                        
                        <li><a>0761285178</a></li>
                        <li><a>Nibm matara</a></li>
                        <li><a>Chalitha@gmail.com</a></li>
                        
                    </ul>
                </div>
                <div class="footer-col">
                    <h4>View Details</h4>
                    <ul>
                    <li><a href="Room.php">Room </a></li>
                        <li><a href="doctor.php">Doctor</a></li>
                        <li><a href="view.php">Appoinment</a></li>
                        
                    </ul>
                </div>
                <div class="footer-col">
                    <h4>follow us</h4>
                    <div class="social-links">
                        <a href="#"><i class="fab fa-facebook-f"></i></a>
                        <a href="#"><i class="fab fa-twitter"></i></a>
                        <a href="#"><i class="fab fa-instagram"></i></a>
                        <a href="#"><i class="fab fa-linkedin-in"></i></a>
                    </div>
                </div>
            </div>
        </div>
   </footer> 

</section>
       
    

   
    <script src="script.js"></script>
    
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.7/js/bootstrap.min.js"></script>

   

      

</body>

</html>


