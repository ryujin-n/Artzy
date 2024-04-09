<?php

include_once('conn.php');

$id=$_SESSION['id'];

try {
    
    $sql_select = $conn->query('SELECT * FROM arte WHERE id_usuario_arte ='.$id.' ORDER BY data_arte DESC');
    
    foreach($sql_select as $linha)
    {
        $class = '';
        $image_dimensions = getimagesize('galeria/'.$id.'/'.$linha['img_arte']);
        $image_height = $image_dimensions[1];
        if ($image_height > 1000) { 
            $class = ' tall';
        }
        else{
            $class= "";
        }
        echo '<div class="it">
                <img src="galeria/'.$id.'/'.$linha['img_arte'].'" alt="" class="'.$class.'">
              </div>';
    }
} catch (PDOException $e) {
    echo "Erro ao inserir arte: " . $e->getMessage();
}
