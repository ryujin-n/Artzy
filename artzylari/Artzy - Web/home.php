<!DOCTYPE html>
<html lang="br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="header&footer/style.css">
    <link rel="stylesheet" href="header&footer/style2.css">
    <link rel="stylesheet" href="css/style-home.css">
    <title>Artzy</title>
</head>
<body>

    <?php include_once("php/auth.php")?>

    <div style="margin-top:-1rem; padding:0 0.2rem 0  0.2rem; ">
        <?php include_once($menu)?>
    </div>

    <!-- 🐛🐛🐛🐛CANAIS RECENTES🐛🐛🐛🐛 -->

    <div class="cr">
      <span class="can"> CANAIS RECENTES </span>
    </div>

    <!-- 🐛🐛🐛🐛 IMAGENS DO CANAIS RECENTES 🐛🐛🐛🐛 -->
    <div class="linha1">
      <div class="img1" id="i">
        <img src="img/1img.jpg" alt="">
      </div>
      <div class="img1" id="i2">
        <img src="img/2img.jpg" alt="">
      </div>
      <div class="img1" id="i3">
        <img src="img/3img.jpg" alt="">
      </div>
      <div class="img1" id="i4">
        <img src="img/4img.jpg" alt="">
      </div>
      <div class="img1" id="i5">
        <img src="img/5img.jpg" alt="">
      </div>
      <div class="img1" id="i6">
        <img src="img/6img.jpg" alt="">
      </div>
      <div class="img1" id="i7">
        <img src="img/7img.jpg" alt="">
      </div>
      <div class="img1" id="i8">
        <img src="img/8img.jpg" alt="">
      </div>
      <div class="img1" id="i9">
        <img src="img/9img.jpg" alt="">
      </div>
      <div class="img1" id="i10">
        <img src="img/10img.jpg" alt="">
      </div>
      <div class="img1" id="i11">
        <img src="img/11img.jpg" alt="">
      </div>
      <div class="img1" id="i12">
        <img src="img/12img.jpg" alt="">
      </div>
    </div>

    <!-- 🐛🐛🐛🐛 TENDENCIA DA LOJA 🐛🐛🐛🐛 -->

    <div class="t">
      <div class="ic">
        <img src="img/icontend.png" alt="" />
      </div>
      <span class="tenden"> TENDÊNCIAS DA LOJA </span>
    </div>

    <!-- 🐛🐛🐛🐛 CARDS TENDENCIA DA LOJA 🐛🐛🐛🐛 -->

    <div class="car">
      <div class="card">
        <div class="daimg">
          <img src="img/lalalalla.jfif" alt="">
        </div>
        <span class="descri"
          >Conjunto de 20 Esboços de Árvores: Traços, Jogos e 2D</span
        >
        <div class="av">
          <span class="avali">5.0</span>
          <span class="des">Baseado em 70 avaliações e 5 comentários</span>
        </div>
        <div class="preço">R$ 60,00</div>
        <div class="circulo">
          <img src="img/batcat.jfif" alt="">
        </div>
        <span class="p">POR:</span>
        <span class="fornome">Annia Art</span>
      </div>
      <div class="card">
        <div class="daimg">
          <img src="img/narizes.jfif" alt="">
        </div>
        <span class="descri"
          >Conjunto +30 esboços de narizes: Feminino e Masculino</span
        >
        <div class="av">
          <span class="avali">4.8</span>
          <span class="des">Baseado em 40 avaliações e 10 comentários</span>
        </div>
        <div class="preço">R$ 80,00</div>
        <div class="circulo">
          <img src="img/aha.jfif" alt="">
        </div>
        <span class="p">POR:</span>
        <span class="fornome">Art Cat</span>
      </div>
      <div class="card">
        <div class="daimg">
          <img src="img/spadas.jfif" alt="">
        </div>
        <span class="descri">
          +48 Espadas: Conjunto medieval, LOL, Vikins.
        </span>
        <div class="av">
          <span class="avali">4.7</span>
          <span class="des">Baseado em 35 avaliações e 10 comentários</span>
        </div>
        <div class="preço">R$ 96,00</div>
        <div class="circulo">
          <img src="img/ih.jfif" alt="">
        </div>
        <span class="p">POR:</span>
        <span class="fornome">LucaStyle</span>
      </div>

      <!-- 🐛🐛🐛🐛 IMAGENS ALEATORIAS 🐛🐛🐛🐛 -->

      <div style="clear: both"></div>
    </div>

    <script src="js/bootstrap.js"></script>
  </body>
</html>
