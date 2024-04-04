<!DOCTYPE html>
<html lang="en">
<head>

    
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="acc.css">
</head>
<body>

<?php include_once('del_acc.php')?>

    <form action="" method="post" onsubmit="return:false;" id="acc" name="acc">

        <div class="cont-tit">
            <span class="conts">
                conta
            </span>
        </div>
    
        <div class="conta">
            <span class="Email">
                Email
            </span>
    
            <input type="text" class="cont-inp">
    
            <button class="enviar3">
                <i class="fi fi-br-file-upload e-i2"></i>
                <span>
                    Salvar
                </span>
            </button>
    
            <div class="Line-29"></div>
    
            <span class="rea-perigosa">
                área perigosa
            </span>
    
            <span class="alerta">
            Observe que, depois de remover sua conta, todas as obras de arte que você postou serão excluídas
            </span>
    
            <button class="Deletar-conta" id="del" name="del" onclick="del()">
                <i class="fi fi-br-file-upload d-i"></i>
                <span>
                    Deletar conta
                </span>
            </button>
        </div>

        <input type="text" 
        style="
            position: absolute; 
            top: 5.2rem;
            left: 9rem;
            /* display:none; */
            
        "
        name="perfill"
        id="perfill"
        value="<?=$id?>">

    </form>

    <script>
        function enviar(tipo) {
            
            const form =document.getElementById("acc")
            form.submit()
        }

    </script>

</body>
</html>