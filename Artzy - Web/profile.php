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
<body class="scrollbar2">
    <div style="margin-top:-1rem; padding:0 0.2rem 0  0.2rem;">
        <?php include_once($menu)?>
    </div>

    <div class="perf-menu">

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


        <div class="perf-fundo scrollbar">
            <div id="profile-p" class="profile-p">
                <img src="pfp/<?= $id?>/<?= $pfp ?>" alt="">
    
                <span class="nome-perfil">
                    <?= $nome ?>
                </span>
    
                <span class="area-perfil" style="font-family: <?= $font ?>;">
                    <?= $prof ?>
                </span>
    
                <div class="foll-perfil">
    
                    <span class="Seguidores">
                        <span class="text-style-1">
                            0
                        </span>
                        <span class="text-style-2">
                            Seguidores
                        </span>
                    </span>
    
                    <span class="Seguindo">
                        <span class="text-style-1">
                           0
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
    
                        <div id="butao" class="botoes"  >
                            <button class="seguir" id="seguir">
                                <span class="icons">
                                    <i id="f" class="fa-solid fa-user-plus waw"></i>
                                    <i id="f2" class="fa-solid fa-user-minus"></i>
                                </span>
                                <span id="seg-tit" class="seg-lbl">Seguir</span>
                            </button>

                            
                            
                            <button class="chat">
                                <span class="icons">
                                    <i class="fi fi-br-envelope"></i>
                                </span>
                                <span class="chat-lbl">
                                    Chat
                                </span>
                            </button>
                        </div>

                        <p class="bio" name="" id="" cols="37" rows="1"><?= $bio?></p>
                                
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
    
 
    <input type="text" 
    style="
        position: absolute; 
        top: 47.6rem;
        left: 50rem;
        display:none;
        
    "
    name="follow"
    id="follow">


        <div class="banner">
            <img src="pfp/banner/<?= $id?>/<?=$banner?>" alt="">
        </div>

        <span class="Portiflio">
            Portifólio
        </span>
            

        <div class="gall">
             <?php include_once("php/galeria_carregar.php")?>
             <div style='clear:both'></div>
        </div>

    <script>
        const seguir = document.getElementById('seguir');
        const f = document.getElementById('f');
        const f2 = document.getElementById('f2');
        const t = document.getElementById('seg-tit');
        const fo = document.getElementById('follow');
        
        seguir.addEventListener('click', function() {
            if (f.style.display === 'none') {
                f.style.display = 'inline-block';
                f2.style.display = 'none';
                t.textContent = 'Seguir';
                fo.value=''
                
            } else {
                f.style.display = 'none';
                f2.style.display = 'inline-block';
                t.textContent = 'Seguindo';
                fo.value='ok'
            }

        });
    </script>

</body>
</html>