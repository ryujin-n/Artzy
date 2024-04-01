<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <?php include_once("php/auth.php")?>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Artzy - Upload</title>
    <link rel="stylesheet" href="css/style-upload.css">
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="header&footer/style.css">
    <link rel="stylesheet" href="header&footer/style2.css">
</head>
<body class="scrollbar">

    <div style="margin-top:-1rem; padding:0 0.2rem 0  0.2rem; ">
        <?php include_once($menu)?>
    </div>
    <div class="upload-cont">
        <span class="ENVIAR-UMA-NOVA-ARTE">
            ENVIAR UMA NOVA ARTE
        </span>

        <span class="art-nome" id="titulo">
            Sem Nome
        </span>

        <div class="upload">
            <div class="Rectangle-283">
                <span class="Ttulo-da-arte" >
                    Título da arte
                </span>
            </div>

            <div class="Rectangle-284">
                <input oninput="legal()" type="text" id="tit-i" name="" class="nome-in" placeholder="Qual o nome da sua arte?">
            </div>

            <div class="Rectangle-285">
                <button class="arquivo">
                    <i class="fi fi-br-folder-upload up-i"></i>
                    <span class="Envie-um-arquivo">
                        Envie um arquivo
                      </span>
                </button>
            </div>

            <div class="Rectangle-286">
                <textarea name="" id="" name="" class="desc scrollbar2" placeholder="Descrição"></textarea>
            </div>

            <div class="categ">
                <span class="Ttulo-da-arte" >
                    Categorias
                </span>
            </div>

            <div class="fundinh">

                <div class="opt "onclick="categ('arte2d')">
                    <span class="Arte-2d selecione-none">
                        Arte 2d
                    </span>
                </div>
                <div class="opt"onclick="categ('arte3d')">
                    <span class="Arte-2d">
                        Arte 3d
                    </span>
                </div>
                <div class="opt"onclick="categ('arte-d')">
                    <span class="Arte-2d">
                        arte digital
                    </span>
                </div>
                <div class="opt"onclick="categ('arte-t')">
                    <span class="Arte-2d">
                        arte tradicional
                    </span>
                </div>
                <div class="opt"onclick="categ('esc')">
                    <span class="Arte-2d">
                        Escultura
                    </span>
                </div>
                <div class="opt"onclick="categ('ft')">
                    <span class="Arte-2d">
                        Foto
                    </span>
                </div>
                <div class="opt"onclick="categ('ad')">
                    <span class="Arte-2d">
                        musica
                    </span>
                </div>
                <div class="opt"onclick="categ('artesa')">
                    <span class="Arte-2d">
                        artesanato
                    </span>
                </div>
                <div class="opt"onclick="categ('px')">
                    <span class="Arte-2d">
                        pixel
                    </span>
                </div>
                <div class="opt"onclick="categ('rl')">
                    <span class="Arte-2d">
                        realista
                    </span>
                </div>
                <div class="opt"onclick="categ('crt')">
                    <span class="Arte-2d">
                        cartoon
                    </span>
                </div>
                <div class="opt"onclick="categ('anm')">
                    <span class="Arte-2d">
                        anime
                    </span>
                </div>
                <div class="opt"onclick="categ('alt')">
                    <span class="Arte-2d">
                        alternativo
                    </span>
                </div>
                <div class="opt"onclick="categ('rck')">
                    <span class="Arte-2d">
                        rock
                    </span>
                </div>
                <div class="opt"onclick="categ('cntry')">
                    <span class="Arte-2d">
                        country
                    </span>
                </div>

            </div>
        </div>

        <div class="thumb">
            <div class="thumbn">
                <span class="Ttulo-da-arte" >
                    Thumbnail
                </span>

                <div class="Rectangle-2851">
                    <button class="arquivo2">
                        <i class="fi fi-br-folder-upload up-i"></i>
                        <span class="Envie-um-arquivo">
                            Envie um arquivo
                          </span>
                    </button>
                </div>
            </div>

            <button class="alt-img">
                <i class="fi fi-br-replace a-i"></i>
                <span class="Alterar-Imagem">
                    Alterar Imagem
                </span>
            </button>

            <button class="enviar">
                <i class="fi fi-br-paper-plane e-i"></i>
                <span class="Alterar-Imagem">
                   publicar
                </span>
            </button>
        </div>

    </div>
  
    <script>

        function legal() {
            let tit = document.getElementById("titulo");
            let tits = document.getElementById("tit-i").value;

            if (tits === "") {
                tit.innerText = "Sem Nome";
            } else {
                tit.innerText = tits;
            }
        }

        function toggleCheck() {
            const offIcon = document.getElementById('off');
            const onIcon = document.getElementById('on');
            const okIcon = document.getElementById('ok');

            if (offIcon.style.display === 'none') {
                offIcon.style.display = 'inline-block';
                onIcon.style.display = 'none';
                okIcon.style.display = 'none';
            } else {
                offIcon.style.display = 'none';
                onIcon.style.display = 'inline-block';
                okIcon.style.display = 'inline-block';
            }
        }

        function categ(categoria) {
            let clickedOpt = categoria.currentTarget;
            let hasClass = clickedOpt.classList.contains('opt_s');

            if (hasClass) {
                clickedOpt.classList.remove('opt_s');
            } else {
                clickedOpt.classList.add('opt_s');
            }
        }

        // Adiciona um ouvinte de evento a todas as divs com a classe opt
        let opts = document.querySelectorAll('.opt');
        opts.forEach(opt => {
            opt.addEventListener('click', categ);
        });

    </script>

</body>
</html>