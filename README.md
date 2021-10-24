<!DOCTYPE html>
<html>
<body>

  <div class="container-fluid">
    <?php
      $files = scandir('instructions/');
      echo "<div class='row'>";
      foreach ($files as $file) {
        if ($file !== "." && $file !== "..") {
          // Give Image source -- src='folder-name/$file'
          echo "<div class=' col-6 col-sm-4 col-md-3 mt-3 mb-3'>
                <img src='instructions/$file' alt='image' width='100%' /></div>";
        }
      }
      echo "</div>";
    ?>
  </div>

</body>
</html>