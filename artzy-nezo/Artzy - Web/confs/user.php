<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="user.css">
</head>
<body>
    <?php include_once("user_alt.php")?>

    <form action="" method="post" onsubmit="return false;" id="userr" name="userr">
        <div class="titulo-p">
            <span class="Perfil">
                Perfil
            </span>

            <span class="sub-t">
                Preencha as informações nos campos para aparecerem nos resultados de pesquisa
            </span>
        </div>

        <div class="info-p">
            <div class="user">
                <span class="Usurio">
                Usuário
                </span>
                <input type="text" name="usuario" id="usuario" class="user-in">
            </div>
            <div class="bio">
                <span class="bio-s">
                    Bio - uma linha sobre você
                </span>
                <input type="text" name="bio" id="bio" class="bio-in" maxlength="65" >
            </div>
            <div class="area-s">
                <span class="bio-s">
                    Área
                </span>
                <button name="area" id="areaa" class="area" onclick="rotateArrow()" onblur="resetArrow()">
                    <span id="bt_n">Selecione sua nova Área</span>
                        <i class="fi fi-br-angle-down" id="setaa"></i>
                            <div class="dp- scrollbar3" id="ddp"> <!--style="display:none;" -->
                                <ul class="ddp-menu">
                                    <li class="ddp-item">
                                        <div class="item-content">
                                            <div class="hov" id="da" onclick="area_sel('da')">Arte Digital</div>
                                        </div>
                                    </li>
                                    
                                    <li class="ddp-item">
                                        <div class="item-content">
                                            <div class="hov" id="ta" onclick="area_sel('ta')">Arte Tradicional</div>
                                        </div>
                                    </li>
                                    <li class="ddp-item">
                                        <div class="item-content">
                                            <div class="hov" id="av"onclick="area_sel('av')">Audiovisual</div>
                                        </div>
                                    </li>
                                
                                    <li class="ddp-item">
                                            <div class="hov" id="wr" onclick="area_sel('wr')">Escrita</div>
                                    </li>
                                </ul>
                            </div>
                </button>
            </div>

            <div class="foto-perfil">
                <div class="profil-p">
                    <img src="pfp/<?= $pfp ?>" alt="">
                </div>

                <button class="arquivo">
                    <i class="fi fi-br-picture up-i"></i>
                    <span class="Envie-um-arquivo">
                        Trocar de Avatar
                    </span>
                </button>
                <input type="file" name="avatar_alt" id="avatar_alt"style=" display:none;">
            </div>

            <div class="banner-perfil">
                <div class="banner-p">
                    <img src="pfp/banner/<?= $banner ?>" alt="">
                </div>

                <button class="arquivo">
                    <i class="fi fi-br-picture up-i"></i>
                    <span class="Envie-um-arquivo">
                        Trocar de Banner
                    </span>
                </button>

                <input type="file" name="banner_alt" id="banner_alt" style=" display:none;">
            </div>

            <button class="enviar">
                <i class="fi fi-br-file-upload e-i"></i>
                <span class="Alterar-Imagem">
                    Salvar
                </span>
            </button>
        </div>

        <input type="text" 
            style="
                position: absolute; 
                top: 40rem;
                display:none;
                
            "
            name="tipo"
            id="tipo">
    </form>

    <script>

        const form =document.getElementById=("userr")
        const user = document.getElementById("usuario")
        const bio =document.getElementById=("bio")
        const banner =document.getElementById("banner_alt")
        const avatar = document.getElementById("avatar_alt")


        function enviar() {
            
        }

        function verify() {
            
             if (user.value == "") {
                alert("Preencha um Usuário válido");
                user.focus();
                return false;
            } else if (tipo.value == "") {
                alert("Preencha uma Área válida");
                setTimeout(function() {
                    area.focus();
                    toggleDropdown()
                }, 0);
                return false;
            } else {
                return true;
            }
        }


         function rotateArrow() {
            const seta = document.getElementById('setaa');

            if (seta.classList.contains("arrow-rotated")) {
                seta.classList.add("arrow-initial");
                seta.classList.remove("arrow-rotated");
                resetDropdown(); 
            } else {
                seta.classList.add("arrow-rotated");
                seta.classList.remove("arrow-initial");
                toggleDropdown(); 
            }
        }

        function resetArrow() {
            const seta = document.getElementById('setaa');
            seta.classList.remove("arrow-rotated");
            seta.classList.add("arrow-initial");
            resetDropdown(); 
        }

        function toggleDropdown() {
            const dropdown = document.getElementById('ddp');
            dropdown.classList.toggle('show'); 
            dropdown.classList.remove('hide');
         }

        function resetDropdown() {
            const dropdown = document.getElementById('ddp');
            const btn = document.getElementById('areaa');

            dropdown.classList.add('hide'); 
            btn.blur()


            setTimeout(function() {
                dropdown.classList.remove('show');
            }, 237);
        }

        function area_sel(type) {

            const btn = document.getElementById('bt_n');

            console.log(type);


            if (type == "da" ) {
                btn.innerText = "Arte Digital"
                tipo.value = "Arte Digital"
            }
            else if (type == "ta"){
                btn.innerText = "Arte Tradicional"
                tipo.value = "Arte Tradicional"
            }
            else if (type == "av"){
                btn.innerText = "Audiovisual"
                tipo.value = "Audiovisual"
            }
            else if (type == "wr"){
                btn.innerText = "Escrita"
                tipo.value = "Escrita"
            }
        }
    </script>
</body>
</html>