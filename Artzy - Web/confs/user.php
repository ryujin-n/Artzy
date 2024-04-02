<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="user.css">
</head>
<body>
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
            <input type="text" name="" id="" class="user-in">
        </div>
        <div class="bio">
            <span class="bio-s">
                Bio - uma linha sobre você
            </span>
            <input type="text" name="" id="" class="bio-in" >
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
        </div>

        <button class="enviar">
            <i class="fi fi-br-file-upload e-i"></i>
            <span class="Alterar-Imagem">
                Salvar
            </span>
        </button>
    </div>

    <script>
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