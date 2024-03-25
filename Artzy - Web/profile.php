<!DOCTYPE html>
<html lang="br">
<head>
    <?php include_once("php/auth.php")?>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/style-profile.css">
    <title>Artzy - <?=$user?> </title>
</head>
<body>
    <div style="margin-top:-1rem; padding:0 0.2rem 0  0.2rem; ">
        <?php include_once($menu)?>
    </div>

    <div class="perf-menu">
        <div class="perf-fundo">
            <div id="profile-p" class="profile-p">
                <img src="pfp/<?=$pfp?>" alt="">

                <span class="nome-perfil">
                    Alysson Kleberr
                </span>
            </div>
        </div>
    </div>


</body>
</html>