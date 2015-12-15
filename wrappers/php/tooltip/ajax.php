<?php
require_once '../lib/Kendo/Autoload.php';

require_once '../include/header.php';

$tooltip = new \Kendo\UI\Tooltip('#products'); // select the container for the tooltip
$tooltip->filter('a')
    ->width(120)
    ->content(array("url" => "../content/web/tooltip/ajax/ajaxContent1.html"))
    ->width(220)
    ->height(280)
    ->requestStart('requestStart')
    ->position('top');

echo $tooltip->render();
?>
    <script>
        var urlFormat = "../content/web/tooltip/ajax/ajaxContent{0}.html";

        function requestStart(e) {
            e.options.url = kendo.format(urlFormat, e.target.data("id"));
        }
    </script>

<div class="demo-section k-content wide">
        <div class="dairy-description">
            <h2>Dairy Products</h2>
            <p>Queso Cabrales, Queso Manchego La Pastora, Gorgonzola Telino, Mascarpone Fabioli, Geitost, Raclette Courdavault, Camembert Pierrott, Gudbrandsdalsost, Flotemysost, Mozzarella di Giovanni</p>
            <p class="demo-hint" style="margin: 1em 0;">Hover an image for details.</p>
        </div>
         <ul id="products" class="dairy-photos">
             <li>
             <a href="#" data-id="1"><img src="../content/web/foods/11.jpg" /></a>
             </li><li>
             <a href="#" data-id="2"><img src="../content/web/foods/12.jpg" /></a>
             </li><li>
             <a href="#" data-id="3"><img src="../content/web/foods/31.jpg" /></a>
             </li><li>
             <a href="#" data-id="4"><img src="../content/web/foods/32.jpg" /></a>
             </li><li>
             <a href="#" data-id="5"><img src="../content/web/foods/33.jpg" /></a>
             </li><li>
             <a href="#" data-id="6"><img src="../content/web/foods/59.jpg" /></a>
             </li><li>
             <a href="#" data-id="7"><img src="../content/web/foods/60.jpg" /></a>
             </li><li>
             <a href="#" data-id="8"><img src="../content/web/foods/69.jpg" /></a>
             </li><li>
             <a href="#" data-id="9"><img src="../content/web/foods/72.jpg" /></a>
             </li>
         </ul>
    </div>

    <style>
        .dairy-photos {
            list-style-type: none;
            margin: 0;
            padding: 0;
            line-height: 0;
        }
        .dairy-photos li {
            display: inline-block;
            margin: 0;
            padding: 0;
            width:110px;
            height: 110px;
            position: relative;
        }
        .dairy-photos li:hover {
            -moz-box-shadow: 0 0 10px rgba(0,0,0,0.8);
            -webkit-box-shadow: 0 0 10px rgba(0,0,0,0.8);
            box-shadow: 0 0 10px rgba(0,0,0,0.8);
            z-index: 1;
        }
        .dairy-photos li,
        .dairy-photos li:hover {
            transition: all .2s;
            -moz-transition: all .2s;
            -webkit-transition: all .2s;
        }
        .dairy-photos a {
            display: inline-block;
        }
        .dairy-description {

        }
        .dairy-description h2 {
            font-size: 2.7em;
            font-weight: normal;
        }
        .dairy-description p {
            line-height: 1.5;
        }
        .dairy-details {
            padding: 10px 0 0 0;
        }
        .dairy-details h3 {
            font-weight: normal;
            font-size: 1.5em;
            margin-top: 10px;
        }
    </style>
<?php require_once '../include/footer.php'; ?>
