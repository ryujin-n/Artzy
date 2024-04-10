<?php
    if ($_POST) {
        if ($_POST['accao']=='email') {
            include_once('conn.php');

            try 
            {
                $sql = $conn->prepare('
                update usuario set
                    email_usuario=:email_usuario
                where id_usuario=:id_usuario
                ');
                $sql->execute(array(
                    ':id_usuario'=>$_POST['perfill'],
                    ':email_usuario'=>$_POST['eemail']
                ));
                if($sql->rowCount() > 0)
                {
                    echo'<script>alert("Email alterado com sucesso")</script>';
                }
            }
            catch (PDOException $erro) {
                echo $erro->getMessage();
            }
        }
    }


    