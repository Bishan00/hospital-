-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Oct 07, 2021 at 04:40 AM
-- Server version: 5.7.31
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hospital`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

DROP TABLE IF EXISTS `account`;
CREATE TABLE IF NOT EXISTS `account` (
  `Num` int(11) NOT NULL,
  `Roll_Id` varchar(10) NOT NULL,
  `Roll_Name` varchar(80) NOT NULL,
  `Login_Username` varchar(50) NOT NULL,
  `Login_Password` varchar(20) NOT NULL,
  `E_mail` varchar(90) DEFAULT NULL,
  `A_Create_Date` date DEFAULT NULL,
  `A_Create_Time` time DEFAULT NULL,
  PRIMARY KEY (`Roll_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `admission_officer`
--

DROP TABLE IF EXISTS `admission_officer`;
CREATE TABLE IF NOT EXISTS `admission_officer` (
  `Number` int(11) NOT NULL,
  `Admission_Officer_Id` varchar(10) NOT NULL,
  `A_Officer_First_Name` varchar(200) NOT NULL,
  `A_Officer_Middle_Name` varchar(200) DEFAULT NULL,
  `A_Officer_Last_Name` varchar(200) NOT NULL,
  `A_Officer_Address` varchar(150) NOT NULL,
  `A_Officer_Tele_Number` int(11) NOT NULL,
  `A_Officer_DOB` date NOT NULL,
  `A_Officer_Salary` decimal(10,0) NOT NULL,
  `A_Job_Start_Date` date NOT NULL,
  `Roll_Id` varchar(8) NOT NULL,
  PRIMARY KEY (`Admission_Officer_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `bill`
--

DROP TABLE IF EXISTS `bill`;
CREATE TABLE IF NOT EXISTS `bill` (
  `Number` int(11) NOT NULL,
  `Bill_Number` varchar(10) NOT NULL,
  `Bill_Amount` float NOT NULL,
  `Payment_Date` date NOT NULL,
  `Payment_Time` time NOT NULL,
  `Payment_Type` varchar(20) NOT NULL,
  `Billing_Officer_Id` varchar(8) NOT NULL,
  `Guardian_Id_Number` varchar(8) NOT NULL,
  PRIMARY KEY (`Bill_Number`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `billing_officer`
--

DROP TABLE IF EXISTS `billing_officer`;
CREATE TABLE IF NOT EXISTS `billing_officer` (
  `Number` int(11) NOT NULL,
  `Billing_Officer_Id` varchar(10) NOT NULL,
  `B_Officer_First_Name` varchar(200) NOT NULL,
  `B_Officer_Middle_Name` varchar(200) DEFAULT NULL,
  `B_Officer_Last_Name` varchar(200) NOT NULL,
  `B_Officer_Address` varchar(150) NOT NULL,
  `B_Officer_Tele_Number` int(11) NOT NULL,
  `B_Officer_DOB` date NOT NULL,
  `B_Officer_Salary` decimal(10,0) NOT NULL,
  `Roll_Id` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`Billing_Officer_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `channeling_officer`
--

DROP TABLE IF EXISTS `channeling_officer`;
CREATE TABLE IF NOT EXISTS `channeling_officer` (
  `Number` int(11) NOT NULL,
  `Channneling_Officer_Id` varchar(10) NOT NULL,
  `Officer_First_Name` varchar(200) NOT NULL,
  `Officer_Middle_Name` varchar(200) DEFAULT NULL,
  `Officer_Last_Name` varchar(200) NOT NULL,
  `Officer_Address` varchar(150) NOT NULL,
  `Officer_Tele_Number` int(11) NOT NULL,
  `Officer_DOB` date NOT NULL,
  `Officer_Salary` decimal(10,0) NOT NULL,
  `Roll_Id` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`Channneling_Officer_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
CREATE TABLE IF NOT EXISTS `customer` (
  `Number` int(11) NOT NULL,
  `Invoice_Number` varchar(10) NOT NULL,
  `Appointment_Number` int(11) NOT NULL,
  `Consultant_Name` varchar(50) NOT NULL,
  `Specialist_Doctor_Id` varchar(9) NOT NULL,
  `Session_Date` varchar(10) NOT NULL,
  `Patient_Name` varchar(90) NOT NULL,
  `Contact_Number` int(11) NOT NULL,
  `Hospital_Fee` int(11) NOT NULL,
  `Doctor_Fee` int(11) NOT NULL,
  `Issue_Time` time NOT NULL,
  `Issue_Date` date NOT NULL,
  `Channneling_Officer_Id` varchar(8) NOT NULL,
  PRIMARY KEY (`Invoice_Number`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `drug`
--

DROP TABLE IF EXISTS `drug`;
CREATE TABLE IF NOT EXISTS `drug` (
  `Number` int(11) NOT NULL,
  `Drug_Code` varchar(10) NOT NULL,
  `Drug_Name` varchar(30) NOT NULL,
  `Trade_Number` varchar(10) NOT NULL,
  `Store_Place` varchar(30) NOT NULL,
  `Drug_Price` float NOT NULL,
  PRIMARY KEY (`Drug_Code`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `drug_order`
--

DROP TABLE IF EXISTS `drug_order`;
CREATE TABLE IF NOT EXISTS `drug_order` (
  `Number` int(11) NOT NULL,
  `Order_Number` varchar(10) NOT NULL,
  `Drug_Code` varchar(11) NOT NULL,
  `Drug_Name` varchar(30) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Order_Date` date NOT NULL,
  `Supplier_Id` varchar(8) NOT NULL,
  `Supply_Date` date NOT NULL,
  `Supply_Time` time NOT NULL,
  `Supply_Quantity` int(11) NOT NULL,
  `Manufacture_Date` date NOT NULL,
  `Expire_Date` date NOT NULL,
  `Total_Bill_Amount` float NOT NULL,
  `Pharmacy_Staff_Id` varchar(8) NOT NULL,
  PRIMARY KEY (`Order_Number`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `drug_supplier`
--

DROP TABLE IF EXISTS `drug_supplier`;
CREATE TABLE IF NOT EXISTS `drug_supplier` (
  `Number` int(11) NOT NULL,
  `Supplier_Id` varchar(10) NOT NULL,
  `Supplier_Name` varchar(90) NOT NULL,
  `Manufacture_Company` varchar(100) NOT NULL,
  `Manufacture_Country` varchar(20) NOT NULL,
  `Manufacture_Reg_Number` varchar(30) NOT NULL,
  PRIMARY KEY (`Supplier_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `guardian`
--

DROP TABLE IF EXISTS `guardian`;
CREATE TABLE IF NOT EXISTS `guardian` (
  `Number` int(11) NOT NULL,
  `Guardian_Id_Number` varchar(10) NOT NULL,
  `Guardian_NIC` char(10) NOT NULL,
  `Guardian_Name` varchar(90) NOT NULL,
  `Guardian_Address` varchar(150) NOT NULL,
  `Gurdian_Tele_No` int(11) NOT NULL,
  `Relationship` varchar(50) NOT NULL,
  `Admission_Officer_Id` varchar(8) NOT NULL,
  `Billing_Officer_Id` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`Guardian_Id_Number`),
  UNIQUE KEY `Guardian_NIC` (`Guardian_NIC`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `hospital_customer`
--

DROP TABLE IF EXISTS `hospital_customer`;
CREATE TABLE IF NOT EXISTS `hospital_customer` (
  `Number` int(11) NOT NULL,
  `Pharmacy_Invoice_Number` varchar(10) NOT NULL,
  `Patient_Id_Number` int(11) NOT NULL,
  `Specialist_Doctor_Id` varchar(9) NOT NULL,
  `Total_Bill` decimal(10,0) NOT NULL,
  `Issue_Date` date NOT NULL,
  `Issue_Time` time NOT NULL,
  `Pharmacy_Staff_Id` varchar(8) NOT NULL,
  PRIMARY KEY (`Pharmacy_Invoice_Number`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `in_patient`
--

DROP TABLE IF EXISTS `in_patient`;
CREATE TABLE IF NOT EXISTS `in_patient` (
  `Number` int(11) NOT NULL,
  `Admission_Number` varchar(10) NOT NULL,
  `Patient_Id_Number` int(11) NOT NULL,
  `Reason` varchar(200) NOT NULL,
  `Admit_Time` time DEFAULT NULL,
  `Admit_Date` date DEFAULT NULL,
  `Discharge_Time` time DEFAULT NULL,
  `Discharge_Date` date DEFAULT NULL,
  `Specialist_Doctor_Id` varchar(9) NOT NULL,
  `Ward_Number` char(10) NOT NULL,
  `Room_Number` char(10) NOT NULL,
  PRIMARY KEY (`Admission_Number`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `in_patient_medicine`
--

DROP TABLE IF EXISTS `in_patient_medicine`;
CREATE TABLE IF NOT EXISTS `in_patient_medicine` (
  `Admission_Number` varchar(9) NOT NULL,
  `Drug_Code` varchar(11) NOT NULL,
  `Quantity` varchar(10) NOT NULL,
  `Given_Time` time NOT NULL,
  `Given_Date` date NOT NULL,
  PRIMARY KEY (`Admission_Number`,`Drug_Code`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `in_patient_report`
--

DROP TABLE IF EXISTS `in_patient_report`;
CREATE TABLE IF NOT EXISTS `in_patient_report` (
  `Number` int(11) NOT NULL,
  `In_Patient_Report_No` varchar(10) NOT NULL,
  `Admission_Number` varchar(9) NOT NULL,
  `Report` blob NOT NULL,
  `Issue_Date` date NOT NULL,
  `Issue_Time` time NOT NULL,
  PRIMARY KEY (`In_Patient_Report_No`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `in_patient_scan`
--

DROP TABLE IF EXISTS `in_patient_scan`;
CREATE TABLE IF NOT EXISTS `in_patient_scan` (
  `Number` int(11) NOT NULL,
  `In_Patient_Scan_No` varchar(10) NOT NULL,
  `Admission_Number` varchar(9) NOT NULL,
  `Scan_Report` blob NOT NULL,
  `Issue_Date` date NOT NULL,
  `Issue_Time` time NOT NULL,
  `Ward_Number` char(10) NOT NULL,
  `Room_Number` char(10) NOT NULL,
  `Specialist_Doctor_Id` varchar(9) NOT NULL,
  PRIMARY KEY (`In_Patient_Scan_No`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `in_patient_xray`
--

DROP TABLE IF EXISTS `in_patient_xray`;
CREATE TABLE IF NOT EXISTS `in_patient_xray` (
  `Number` int(11) NOT NULL,
  `In_Patient_X_Ray_No` varchar(10) NOT NULL,
  `Admission_Number` varchar(9) NOT NULL,
  `X_Ray` blob NOT NULL,
  `Issue_Date` date NOT NULL,
  `Issue_Time` time NOT NULL,
  `Ward_Number` char(10) NOT NULL,
  `Room_Number` char(10) NOT NULL,
  `Specialist_Doctor_Id` varchar(9) NOT NULL,
  PRIMARY KEY (`In_Patient_X_Ray_No`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `in_sample`
--

DROP TABLE IF EXISTS `in_sample`;
CREATE TABLE IF NOT EXISTS `in_sample` (
  `Number` int(11) NOT NULL,
  `Sample_In_Number` varchar(10) NOT NULL,
  `Patient_Id_Number` int(11) NOT NULL,
  `Sample_Type` varchar(10) NOT NULL,
  `Ward_Number` char(10) NOT NULL,
  `Room_Number` char(10) NOT NULL,
  `Specialist_Doctor_Id` varchar(9) NOT NULL,
  `Laboratory_Staff_Id` varchar(8) NOT NULL,
  `Received_Date` date NOT NULL,
  `Received_Time` time NOT NULL,
  PRIMARY KEY (`Sample_In_Number`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `laboratory_staff`
--

DROP TABLE IF EXISTS `laboratory_staff`;
CREATE TABLE IF NOT EXISTS `laboratory_staff` (
  `Number` int(11) NOT NULL,
  `Laboratory_Staff_Id` varchar(10) NOT NULL,
  `L_Officer_First_Name` varchar(200) DEFAULT NULL,
  `L_Officer_Middle_Name` varchar(200) DEFAULT NULL,
  `L_Officer_Last_Name` varchar(200) NOT NULL,
  `L_Officer_Address` varchar(150) NOT NULL,
  `L_Officer_Tele_Number` int(11) NOT NULL,
  `L_Officer_DOB` date NOT NULL,
  `L_Officer_Salary` decimal(10,0) NOT NULL,
  `Designation` varchar(30) NOT NULL,
  `L_Job_Start_Date` date NOT NULL,
  PRIMARY KEY (`Laboratory_Staff_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `log_in_user`
--

DROP TABLE IF EXISTS `log_in_user`;
CREATE TABLE IF NOT EXISTS `log_in_user` (
  `Roll_Id` varchar(8) NOT NULL,
  `Roll_name` varchar(80) DEFAULT NULL,
  `First_Name` varchar(100) NOT NULL,
  `Middle_Name` varchar(100) DEFAULT NULL,
  `Surname` varchar(100) NOT NULL,
  `User_Address` varchar(100) DEFAULT NULL,
  `Img` varchar(100) DEFAULT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `User_Tele_No` int(11) DEFAULT NULL,
  `Date_Of_Birth` date DEFAULT NULL,
  `Designation` varchar(50) DEFAULT NULL,
  `Salary` decimal(10,0) NOT NULL,
  PRIMARY KEY (`Roll_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `organization`
--

DROP TABLE IF EXISTS `organization`;
CREATE TABLE IF NOT EXISTS `organization` (
  `Goverment_Reg_Number` varchar(20) NOT NULL,
  `Organization_Name` varchar(150) NOT NULL,
  `Organization_Address` varchar(150) NOT NULL,
  `Bill_Number` varchar(11) NOT NULL,
  `Billing_Officer_Id` varchar(8) NOT NULL,
  PRIMARY KEY (`Goverment_Reg_Number`),
  UNIQUE KEY `Goverment_Reg_Number` (`Goverment_Reg_Number`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `out_patient`
--

DROP TABLE IF EXISTS `out_patient`;
CREATE TABLE IF NOT EXISTS `out_patient` (
  `Out_Patient_Id_Number` int(11) NOT NULL,
  `Patient_Name` varchar(70) NOT NULL,
  `Guardian_NIC` varchar(12) NOT NULL,
  `Guardian_Tele_No` int(11) NOT NULL,
  `Age` int(11) NOT NULL,
  `Reason` varchar(200) NOT NULL,
  `C_Date` date NOT NULL,
  `C_Time` time NOT NULL,
  `Specialist_Doctor_Id` varchar(9) NOT NULL,
  PRIMARY KEY (`Out_Patient_Id_Number`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `out_patient_medicine`
--

DROP TABLE IF EXISTS `out_patient_medicine`;
CREATE TABLE IF NOT EXISTS `out_patient_medicine` (
  `Out_Patient_Id_Number` int(11) NOT NULL,
  `Drug_Code` varchar(11) NOT NULL,
  `Quantity` varchar(10) NOT NULL,
  `Number_Of_Day` int(11) NOT NULL,
  `Issue_Date` date NOT NULL,
  PRIMARY KEY (`Out_Patient_Id_Number`,`Drug_Code`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `out_patient_report`
--

DROP TABLE IF EXISTS `out_patient_report`;
CREATE TABLE IF NOT EXISTS `out_patient_report` (
  `Number` int(11) NOT NULL,
  `Out_Patient_Report_No` varchar(10) NOT NULL,
  `Patient_Id_Number` int(11) NOT NULL,
  `Report` blob NOT NULL,
  `Issue_Date` date NOT NULL,
  `Issue_Time` time NOT NULL,
  PRIMARY KEY (`Out_Patient_Report_No`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `out_patient_scan`
--

DROP TABLE IF EXISTS `out_patient_scan`;
CREATE TABLE IF NOT EXISTS `out_patient_scan` (
  `Number` int(11) NOT NULL,
  `Out_Patient_Scan_No` varchar(10) NOT NULL,
  `Patient_Id_Number` int(11) NOT NULL,
  `Scan_Report` blob NOT NULL,
  `Issue_Date` date NOT NULL,
  `Issue_Time` time NOT NULL,
  `Specialist_Doctor_Id` varchar(9) NOT NULL,
  PRIMARY KEY (`Out_Patient_Scan_No`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `out_patient_xray`
--

DROP TABLE IF EXISTS `out_patient_xray`;
CREATE TABLE IF NOT EXISTS `out_patient_xray` (
  `Number` int(11) NOT NULL,
  `Out_Patient_Xray_No` varchar(10) NOT NULL,
  `Patient_Id_Number` int(11) NOT NULL,
  `X_Ray` blob NOT NULL,
  `Issue_Date` date NOT NULL,
  `Issue_Time` time NOT NULL,
  PRIMARY KEY (`Out_Patient_Xray_No`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `out_sample`
--

DROP TABLE IF EXISTS `out_sample`;
CREATE TABLE IF NOT EXISTS `out_sample` (
  `Number` int(11) NOT NULL,
  `Sample_Out_Number` varchar(10) NOT NULL,
  `Patient_Id_Number` int(11) NOT NULL,
  `Sample_Type` varchar(10) NOT NULL,
  `Specialist_Doctor_Id` varchar(9) NOT NULL,
  `Laboratory_Staff_Id` varchar(8) NOT NULL,
  `Received_Date` date NOT NULL,
  `Received_Time` time NOT NULL,
  PRIMARY KEY (`Sample_Out_Number`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `patient_appointment_details`
--

DROP TABLE IF EXISTS `patient_appointment_details`;
CREATE TABLE IF NOT EXISTS `patient_appointment_details` (
  `Patient_Id_Number` int(11) NOT NULL,
  `Invoice_Number` varchar(8) NOT NULL,
  PRIMARY KEY (`Patient_Id_Number`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `patient_private_detail`
--

DROP TABLE IF EXISTS `patient_private_detail`;
CREATE TABLE IF NOT EXISTS `patient_private_detail` (
  `Patient_Id_Number` int(11) NOT NULL,
  `Patient_First_Name` varchar(200) NOT NULL,
  `Patient_Middle_Name` varchar(200) DEFAULT NULL,
  `Patient_Last_Name` varchar(200) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `Date_Of_Birth` date NOT NULL,
  `Age` int(11) NOT NULL,
  `Blood_Group` char(50) NOT NULL,
  `Guardian_Id_Number` varchar(8) NOT NULL,
  `Specialist_Doctor_Id` varchar(9) NOT NULL,
  PRIMARY KEY (`Patient_Id_Number`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `pharmacy_medicines`
--

DROP TABLE IF EXISTS `pharmacy_medicines`;
CREATE TABLE IF NOT EXISTS `pharmacy_medicines` (
  `Pharmacy_Invoice_Number` varchar(9) NOT NULL,
  `Drug_Code` varchar(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Number_Of_Days` int(11) NOT NULL,
  PRIMARY KEY (`Pharmacy_Invoice_Number`,`Drug_Code`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `pharmacy_staff`
--

DROP TABLE IF EXISTS `pharmacy_staff`;
CREATE TABLE IF NOT EXISTS `pharmacy_staff` (
  `Number` int(11) NOT NULL,
  `Pharmacy_Staff_Id` varchar(10) NOT NULL,
  `P_Officer_First_Name` varchar(200) NOT NULL,
  `P_Officer_Middle_Name` varchar(200) DEFAULT NULL,
  `P_Officer_Last_Name` varchar(200) NOT NULL,
  `P_Officer_Address` varchar(150) NOT NULL,
  `P_Officer_Tele_Number` int(11) NOT NULL,
  `P_Officer_DOB` date NOT NULL,
  `P_Officer_Salary` decimal(10,0) NOT NULL,
  `Designation` varchar(30) NOT NULL,
  `P_Job_Start_Date` date NOT NULL,
  `Roll_Id` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`Pharmacy_Staff_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `qualification`
--

DROP TABLE IF EXISTS `qualification`;
CREATE TABLE IF NOT EXISTS `qualification` (
  `Specialist_Doctor_Id` varchar(9) NOT NULL,
  `Qualification` varchar(20) NOT NULL,
  PRIMARY KEY (`Specialist_Doctor_Id`,`Qualification`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `report_in_patient`
--

DROP TABLE IF EXISTS `report_in_patient`;
CREATE TABLE IF NOT EXISTS `report_in_patient` (
  `Admission_Number` varchar(9) NOT NULL,
  `In_Patient_Report_No` varchar(9) NOT NULL,
  `In_Patient_Xray_No` varchar(9) DEFAULT NULL,
  `In_Patient_Scan_No` varchar(9) DEFAULT NULL,
  PRIMARY KEY (`Admission_Number`,`In_Patient_Report_No`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `report_out_patient`
--

DROP TABLE IF EXISTS `report_out_patient`;
CREATE TABLE IF NOT EXISTS `report_out_patient` (
  `Out_Patient_Id_Number` int(11) NOT NULL,
  `Out_Patient_Report_No` varchar(9) NOT NULL,
  `Out_Patient_Xray_No` varchar(9) DEFAULT NULL,
  `Out_Patient_Scan_No` varchar(9) DEFAULT NULL,
  PRIMARY KEY (`Out_Patient_Id_Number`,`Out_Patient_Report_No`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

DROP TABLE IF EXISTS `room`;
CREATE TABLE IF NOT EXISTS `room` (
  `Room_Number` char(10) NOT NULL,
  `Room_Name` varchar(70) NOT NULL,
  `Room_Type` varchar(90) NOT NULL,
  `Room_Availability` char(10) NOT NULL,
  `Ward_Number` char(10) NOT NULL,
  PRIMARY KEY (`Room_Number`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `scan_room`
--

DROP TABLE IF EXISTS `scan_room`;
CREATE TABLE IF NOT EXISTS `scan_room` (
  `Number` int(11) NOT NULL,
  `S_Staff_Id` varchar(10) NOT NULL,
  `S_Officer_First_Name` varchar(200) NOT NULL,
  `S_Officer_Middle_Name` varchar(200) DEFAULT NULL,
  `S_Officer_Last_Name` varchar(200) NOT NULL,
  `S_Officer_Address` varchar(150) NOT NULL,
  `S_Officer_Tele_Number` int(11) NOT NULL,
  `S_Officer_DOB` date NOT NULL,
  `S_Officer_Salary` decimal(10,0) NOT NULL,
  `Designation` varchar(30) NOT NULL,
  `S_Job_Start_Date` date NOT NULL,
  PRIMARY KEY (`S_Staff_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `specialist_doctor`
--

DROP TABLE IF EXISTS `specialist_doctor`;
CREATE TABLE IF NOT EXISTS `specialist_doctor` (
  `Number` int(11) NOT NULL,
  `Specialist_Doctor_Id` varchar(10) NOT NULL,
  `SLMC_Reg_Number` char(20) NOT NULL,
  `Title` varchar(10) NOT NULL,
  `S_Doctor_Name` varchar(50) NOT NULL,
  `S_Field` varchar(20) NOT NULL,
  `S_Doctor_Type` char(20) NOT NULL,
  `S_Doctor_Address` varchar(100) NOT NULL,
  `S_Doctor_Tele_Number` int(11) NOT NULL,
  `S_Doctor_Monthly_Salary` decimal(10,0) NOT NULL,
  `S_Doctor_Job_Start_Date` date NOT NULL,
  `Ward_Number` char(10) NOT NULL,
  PRIMARY KEY (`Specialist_Doctor_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `ward`
--

DROP TABLE IF EXISTS `ward`;
CREATE TABLE IF NOT EXISTS `ward` (
  `Ward_Number` char(10) NOT NULL,
  `Ward_Name` varchar(70) NOT NULL,
  PRIMARY KEY (`Ward_Number`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `ward_staff`
--

DROP TABLE IF EXISTS `ward_staff`;
CREATE TABLE IF NOT EXISTS `ward_staff` (
  `Number` int(11) NOT NULL,
  `Ward_Staff_Id` varchar(10) NOT NULL,
  `W_Officer_First_Name` varchar(200) NOT NULL,
  `W_Officer_Middle_Name` varchar(200) DEFAULT NULL,
  `W_Officer_Last_Name` varchar(200) NOT NULL,
  `W_Officer_Address` varchar(150) NOT NULL,
  `W_Officer_Tele_Number` int(11) NOT NULL,
  `W_Officer_DOB` date NOT NULL,
  `W_Officer_Salary` decimal(10,0) NOT NULL,
  `Designation` varchar(30) NOT NULL,
  `W_Job_Start_Date` date NOT NULL,
  `Ward_Number` char(10) NOT NULL,
  `Roll_Id` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`Ward_Staff_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `x_ray_room`
--

DROP TABLE IF EXISTS `x_ray_room`;
CREATE TABLE IF NOT EXISTS `x_ray_room` (
  `Number` int(11) NOT NULL,
  `Staff_Id` varchar(10) NOT NULL,
  `X_Officer_First_Name` varchar(200) NOT NULL,
  `X_Officer_Middle_Name` varchar(200) NOT NULL,
  `X_Officer_Last_Name` varchar(200) NOT NULL,
  `X_Officer_Address` varchar(150) NOT NULL,
  `X_Officer_Tele_Number` int(11) NOT NULL,
  `X_Officer_DOB` date NOT NULL,
  `X_Officer_Salary` decimal(10,0) NOT NULL,
  `Designation` varchar(30) NOT NULL,
  `X_Job_Start_Date` date NOT NULL,
  PRIMARY KEY (`Staff_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
