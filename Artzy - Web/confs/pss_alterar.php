<?php

    if ($_POST) {
        include_once('conn.php');

        try 
        {
            $sql = $conn->prepare('
            update usuario set
                senha_usuario=:senha_usuario
            where id_usuario=:id_usuario
            ');
            $sql->execute(array(
                ':id_usuario'=>$_POST['perfill'],
                ':senha_usuario'=>$_POST['senha1']
            ));
            if($sql->rowCount() > 0)
            {
                echo'<script>alert("Senha alterada com sucesso")</script>';
            }
        }
        catch (PDOException $erro) {
            echo $erro->getMessage();
        }
    }