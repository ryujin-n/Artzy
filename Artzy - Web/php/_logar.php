<?php

    $auth = "";

if($_POST) {
    
    $auth = "none";

    include_once("conn.php");
    
    try {
        $sql = $conn->query("select * from usuario
        WHERE 
        (login_usuario = '".$_POST['nome']."' OR email_usuario = '".$_POST['nome']."') 
        AND 
        senha_usuario='".$_POST['senha']."'");
        
        
        
        if($sql->rowCount() == 1)
        {
            foreach($sql as $linha)
            {
                session_start();
                $_SESSION['nomeUsuarioLogin'] = $linha[1];
                $_SESSION['loginUsuarioLogin'] = $linha[2];
                $_SESSION['fotoPerfilUsuario'] = $linha[4];
                $_SESSION['emailUsuarioLogin'] = $linha[5];
                header('Location:home.php');

            }
        }
        else
        {
            $auth = "block";
        }
    } catch(PDOException $erro) {
        echo $erro->getMessage();
    }
}