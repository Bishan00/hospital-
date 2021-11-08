<?php
    session_start();
	require_once 'database.php';
    $message="";
	extract($_POST);
	if(isset($_POST['register'])){
		header("Location:register.php");
	}
	if(isset($_POST['login'])) {
    $uname = $_POST['Username'];
	$pass = $_POST['Password'];
    
    if(count($_POST)>0) {
       
        $result = mysqli_query($conn,"SELECT * FROM `account` WHERE `Login_Username`='$uname' AND `Login_Password`='$pass'");
        $row  = mysqli_fetch_array($result);
        if(is_array($row)) {
        $_SESSION["ID"] = $_POST['Login_Username'];
		
        $_SESSION["password"] = $_POST['Password'];
		
		
			
		            
							  
							              
	    
		
		header("Location:Appointment.php");
		 
		
		
		}else{
			
	        echo '<script>alert("Not Succesfuly Login !...")</script>';      
             
			
		}
		
		
	
        } else {
			
			
		
		}
		
		
	}
		
    
    
?>