<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <?php include_once("php/auth.php")?>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Artzy - Configurações</title>
    <link rel="stylesheet" href="css/style-conf.css">
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="header&footer/style.css">
    <link rel="stylesheet" href="header&footer/style2.css">
    <link rel="stylesheet" href="confs/user.css">
    <link rel="stylesheet" href="confs/rs.css">
    <link rel="stylesheet" href="confs/acc.css">
    <link rel="stylesheet" href="confs/pss.css">
    
</head>
<body class="scrollbar2">
    <div style="margin-top:-1rem; padding:0 0.2rem 0  0.2rem; ">
        <?php include_once($menu)?>
    </div>
    <div style="menu-m">
        <?php include_once("_menu.php")?>
    </div>
    <div class="confs">
        <?php
            if(isset($_GET['tela']))
            {
                $tela = $_GET['tela'];

                if($tela=='perfil')
                {
                    include_once("confs/user.php");
                }
                if($tela=='social')
                {
                    include_once("confs/rs.php");
                }
                else if($tela=='conta')
                {
                    include_once("confs/acc.php");
                }
                else if($tela=='senha')
                {
                    include_once("confs/pss.php");
                }
                
            }
            else
            {
                include_once("confs/user.php");
                
            }
        ?>
    </div>
</body>
</html>