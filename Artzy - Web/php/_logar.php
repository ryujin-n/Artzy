<?php

$merro = "false";
$caminho="";

if($_POST)
{
    include_once('conn.php');
    
    try
    {
        $sql = $conn->query("select * from user
            where 
            login_usuario ='".$_POST['nome']."' 
            and 
            email_usuario ='".$_POST['nome']."' 
            and 
            senha_usuario='".$_POST['senha']."'");
    
        if($sql->rowCount() == 1)
        {
            foreach($sql as $linha)
            {
                session_start();
                $_SESSION['idUsuarioLogin'] = $linha[0];
                $_SESSION['nomeUsuarioLogin'] = $linha[1];
                $_SESSION['loginUsuarioLogin'] = $linha[2];
                header('Location:home.php');
            }
        }
        else
        {
            $merro = "true";
        }
        
    }
    catch(PDOException $erro)
    {
        echo $erro->getMessage();
    }
}