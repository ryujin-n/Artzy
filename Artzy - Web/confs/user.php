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
                    <i class="fi fi-br-angle-down" id="seta"></i>
                        <div class="dp scrollbar" id="ddp"> <!--style="display:none;" -->
                            <ul class="dp-menu">
                                <li class="dp-item">
                                    <div class="item-content">
                                        <div class="hov" id="da" onclick="area_sel('da')">Arte Digital</div>
                                    </div>
                                </li>
                                
                                <li class="dp-item">
                                    <div class="item-content">
                                        <div class="hov" id="ta" onclick="area_sel('ta')">Arte Tradicional</div>
                                    </div>
                                </li>
                                <li class="dp-item">
                                    <div class="item-content">
                                        <div class="hov" id="av"onclick="area_sel('av')">Audiovisual</div>
                                    </div>
                                </li>
                            
                                <li class="dp-item">
                                        <div class="hov" id="wr" onclick="area_sel('wr')">Escrita</div>
                                </li>
                            </ul>
                        </div>
            </button>
        </div>
    </div>

    <script>
         function rotateArrow() {
            const seta = document.getElementById('seta');

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
            const seta = document.getElementById('seta');
            seta.classList.remove("arrow-rotated");
            seta.classList.add("arrow-initial");
            resetDropdown(); 
        }

        // function toggleDropdown() {
        //     const dropdown = document.getElementById('ddp');
        //     dropdown.classList.toggle('show'); 
        //     dropdown.classList.remove('hide');
        //  }

        // function resetDropdown() {
        //     const dropdown = document.getElementById('ddp');
        //     const btn = document.getElementById('areaa');

        //     dropdown.classList.add('hide'); 
        //     btn.blur()


        //     setTimeout(function() {
        //         dropdown.classList.remove('show');
        //     }, 237);
        // }
    </script>
</body>
</html>