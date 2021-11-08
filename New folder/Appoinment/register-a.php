<?php 
session_start();
require_once 'database.php';
if(isset($_POST['register'])){
	  
	$Login_Username = $_POST['uname'];
    $Login_Password = $_POST['password'];
	$E_mail = $_POST['email'];
	
		
	
$conn = new mysqli('localhost','root','','hospital');
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}     
	$sql= "INSERT INTO `account`( `Roll_Name`, `Login_Username`, `Login_Password`, `E_mail` ) VALUES ('Customer','$Login_Username','$Login_Password','$E_mail')";

	
	 
	if ($conn->query($sql) === TRUE) {

     $_SESSION["ID"] = $_POST['pno'];
	 echo '<script>alert(" Succesfuly Registation !...")</script>'; 
	 header("Location:login.php");
	
  
     
  
			 
  
}else{
	
	echo '<script>alert("Not Succesfuly Registation !...")</script>'; 
	header("Location:register.php");
}

$conn->close();

}



?>