<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <?php include_once("php/auth.php")?>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/style-menu.css">
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="header&footer/style.css">
    <link rel="stylesheet" href="header&footer/style2.css">
    <title>Document</title>
</head>
<body>
    <div class="fundo">
        <div class="pfp">
            <img src="pfp/<?= $pfp ?>" alt="">
        </div>

        <div class="txt">
            <span class="Configuraes">
                Configurações
            </span>

            <div class="info-container">
                <span class="nome">
                    <?= $nome ?>
                </span>
                <span class="time">
                    Membro desde <?= $data ?>
                </span>
            </div>
        </div>

        <div class="menu__">
            <a href="conf.php?tela=perfil" class="item-m">
                <span>
                    Perfil
                </span>
            </a>
            <a href="conf.php?tela=redes-sociais">
                <span>
                    Redes Sociais
                </span>
            </a>

            <div id="hr2" class="hr"></div>

            <a href="conf.php?tela=conta">
                <span>
                    Conta
                </span>
            </a>
            <a href="conf.php?tela=senha">
                <span>
                    Senha
                </span>
            </a>
        </div>

        
    </div>

   


</body>
</html>