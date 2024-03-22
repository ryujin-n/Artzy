<?php

    if ($_POST) {
        print_r($_POST);

        if($_POST['ook']=='ok'){

            include_once('conn.php');


            try {
                $sql = $conn->prepare('
                insert into user
                    (nome_usuario,senha_usuario,email_usuario,area_usuario)
                    values(:nome_usuario,:senha_usuario,:email_usuario,:area_usuario)
                ');
        
                $sql->execute(array(
                    ':nome_usuario'=>$_POST['nome'],
                    ':senha_usuario'=>$_POST['senha'],
                    ':email_usuario'=>$_POST['email'],
                    ':area_usuario'=>$_POST['tipo'],
                ));

                if($sql->rowCount() > 0)
                {
                    $name = $_POST['nome'];

                    header("Location:home.php?user=".$name);
                }
        
            } 
            catch (PDOException $erro) {
                echo $erro->getMessage();
            }
        }
        
    }