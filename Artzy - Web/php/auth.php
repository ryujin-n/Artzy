<?php

    
session_start();

if (isset($_SESSION['nomeUsuarioLogin'])) {
    date_default_timezone_set('America/Sao_Paulo');
    $id = $_SESSION['id'];
    $menu = "header&footer/header_signedon.php";
    $pfp = $_SESSION['fotoPerfilUsuario'];
    $data= $_SESSION['dataUsuario'];
    $data = date("F j, Y");
    $email = $_SESSION['emailUsuarioLogin'];
    $user = $_SESSION['loginUsuarioLogin'];
    $nome = $_SESSION['nomeUsuarioLogin'];
    $area = $_SESSION['areaUsuarioLogin'];
    $banner = $_SESSION['bannerPerfilUsuario'];
    $seguidores = $_SESSION['seguidores'];
    $seguindo = $_SESSION['seguindo'];
    

} else {
    $menu = "header&footer/header_signedoff.php";
}