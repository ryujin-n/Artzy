<!DOCTYPE html>
<html lang="br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="header&footer/style.css">
    <link rel="stylesheet" href="header&footer/style2.css">
    <link rel="stylesheet" href="css/style-loja.css">

    <title>Artzy - Loja</title>
</head>
<body>

    <?php include_once("php/auth.php")?>

    <div style="margin-top:-1rem; padding:0 0.2rem 0  0.2rem; ">
        <?php include_once($menu)?>
    </div>


    <!-- 🐛🐛🐛🐛CANAIS RECENTES🐛🐛🐛🐛 -->

    <div class="dicarrinho">
        <div class="carrinho">
            <img src="img/carrinho.png" alt="">
        </div>
        <span class="pare">OPS! CARRINHO VAZIO</span>
        <span class="confira">Confira alguns produtos abaixo =)</span>
    </div>

    <!-- 🐛🐛🐛🐛CARROSEL🐛🐛🐛🐛 -->

    <div class="carrr">
        <div class="cartaoo">
            <div class="daimgg" id="daimg1" >
              <img src="img/B1.png" alt="">
            </div>
          </div>
          <div class="cartaoo">
            <div class="daimgg" id="daimg2" >
              <img src="img/B2.png" alt="">
            </div>
          </div>
          <div class="cartaoo">
            <div class="daimgg" id="daimg3" >
              <img src="img/B3.png" alt="">
            </div>
          </div>
    </div>
    

    <script src="js/bootstrap.js"></script>

    


</body>
</html>