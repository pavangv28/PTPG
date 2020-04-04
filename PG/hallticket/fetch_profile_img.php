<?php
session_start();
$con=mysqli_connect("localhost","root","")or die("Unnable to connect");
mysqli_select_db($con,"meapp");


$halltno=$_SESSION['hnumber'];

$sel_img="SELECT * FROM `studentdata` WHERE hallticketno='$halltno'";

$q_run=mysqli_query($con,$sel_img);

if($row=mysqli_fetch_assoc($q_run))
{
    $imgName=$row[];
    $imgContent=$row[];
}





session_destroy();
?>