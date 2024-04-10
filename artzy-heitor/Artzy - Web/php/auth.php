<?php

    
session_start();

if (isset($_SESSION['nomeUsuarioLogin'])) {
    $id = $_SESSION['id'];
    $menu = "header&footer/header_signedon.php";
    $pfp = $_SESSION['fotoPerfilUsuario'];
    $data= $_SESSION['dataUsuario'];
    $data_formatada = new DateTime($data);
    $data_formatada_pt = $data_formatada->format("F \\d\\e Y");
    $email = $_SESSION['emailUsuarioLogin'];
    $user = $_SESSION['loginUsuarioLogin'];
    $nome = $_SESSION['nomeUsuarioLogin'];
    $area = $_SESSION['areaUsuarioLogin'];
    $banner = $_SESSION['bannerPerfilUsuario'];
    $bio =  $_SESSION['bioUsuarioLogin'];    

} else {
    $menu = "header&footer/header_signedoff.php";

       
}