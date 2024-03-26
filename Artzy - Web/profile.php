<!DOCTYPE html>
<html lang="br">
<head>
    <?php include_once("php/auth.php")?>
    <?php include_once("php/area.php")?>
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
        <div class="perf-fundo scrollbar">
            <div id="profile-p" class="profile-p">
                <img src="pfp/<?= $pfp ?>" alt="">
    
                <span class="nome-perfil">
                    <?= $nome ?>
                </span>
    
                <span class="area-perfil" style="font-family: <?= $font ?>;">
                    <?= $prof ?>
                </span>
    
                <div class="foll-perfil">
    
                    <span class="Seguidores">
                        <span class="text-style-1">
                            <?= $seguidores ?>
                        </span>
                        <span class="text-style-2">
                            Seguidores
                        </span>
                    </span>
    
                    <span class="Seguindo">
                        <span class="text-style-1">
                            <?= $seguindo ?>
                        </span>
                        <span class="text-style-2">
                            Seguindo
                        </span>
                    </span>
    
                    <div id="infos">
                        <div id="job" class="info">
                            <div class="icones">
                                <i class="fi fi-sr-briefcase"></i>
                            </div>
                            <div class="text">
                                <p>Profissão</p>
                            </div>
                        </div>
                        <div id="loc" class="info">
                            <div class="icones">
                                <i class="fi fi-sr-marker"></i>
                            </div>
                            <div class="text">
                                <p>Local</p>
                            </div>
                        </div>
                        <div id="info" class="info ">
                            <div class="icones">
                                <i class="fi fi-br-globe"></i>
                            </div>
                            <div class="text">
                                <p>Site</p>
                            </div>
                        </div>
    
                        <div id="butao" class="botoes">
                            <button class="seguir">
                                <span class="icons">
                                    <i class="fa-solid fa-user-plus waw"></i>
                                    <i class="fa-solid fa-user-minus" style="display:none;"></i>
                                </span>
                                <span class="seg-lbl">
                                    Seguir
                                </span>
                            </button>
    
                            <button class="chat">
                                <span class="icons">
                                    <i class="fi fi-br-envelope"></i>
                                </span>
                                <span class="chat-lbl">
                                    Chat
                                </span>
                            </button>
    
                            <textarea class="bio" name="" id="" cols="37" rows="1">Bio
                            </textarea>
    
                            <div class="Line-27"></div>
    
                            <p style="  font-family: MomcakePro;
                                        font-size: 17px;
                                        font-weight: bold;
                                        font-stretch: normal;
                                        font-style: normal;
                                        line-height: normal;
                                        letter-spacing: normal;
                                        text-align: left;
                                        color: #e8a542;">
                                Redes Sociais
                            </p>
    
                            <div id="socials">
                                <div id="job" class="info">
                                    <div class="icones">
                                        <i class="fa-brands fa-instagram"></i>
                                    </div>
                                    <div class="text">
                                        <a href="">
                                            <p>@admin</p>
                                        </a>
                                    </div>
                                </div>
                                <div id="loc" class="info">
                                    <div class="icones">
                                        <i class="fa-brands fa-tiktok"></i>
                                    </div>
                                    <div class="text">
                                        <a href="">
                                            <p>admin</p>
                                        </a>
                                    </div>
                                </div>
                                <div id="info" class="info ">
                                    <div class="icones">
                                        <i class="fa-brands fa-x-twitter"></i>
                                    </div>
                                    <div class="text">
                                        <a href="">
                                            <p>@admin</p>
                                        </a>
                                    </div>
                                </div>
                                <div id="site" class="info">
                                    <div class="icones">
                                        <i class="fi fi-br-site-alt"></i>
                                    </div>
                                    <div class="text">
                                        <a href="">
                                            <p>admin.com</p>
                                        </a>
                                    </div>
                                </div>
    
                                <div class="Line-27"></div>
    
                            </div>
    
                            <p style="  font-family: MomcakePro;
                                    font-size: 17px;
                                    font-weight: bold;
                                    font-stretch: normal;
                                    font-style: normal;
                                    line-height: normal;
                                    letter-spacing: normal;
                                    text-align: left;
                                    color: #e8a542;">
                                Contato
                            </p>
    
                            <div id="contat" class="info">
                                <div class="icones">
                                    <i class="fa-solid fa-at"></i>
                                </div>
                                <div class="text">
                                    <p>
                                        <?= $email ?>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="banner">
        <img src="pfp/banner/<?=$banner?>" alt="">
    </div>
    

</body>
</html>