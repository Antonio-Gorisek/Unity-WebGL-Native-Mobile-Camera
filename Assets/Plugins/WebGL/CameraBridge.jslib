mergeInto(LibraryManager.library, {

  OpenNativeCamera: function (front) {

    let input = document.getElementById("unityCameraInput");

    if (!input) {

      input = document.createElement("input");
      input.type = "file";
      input.accept = "image/*";
      input.id = "unityCameraInput";
      input.style.display = "none";

      input.onchange = function (e) {

        const file = e.target.files[0];

        if (!file) return;

        const reader = new FileReader();

        reader.onload = function () {

          Module.SendMessage(
            "CameraManager",
            "OnImageReceived",
            reader.result
          );
        };

        reader.readAsDataURL(file);

        input.value = "";
      };

      document.body.appendChild(input);
    }

    input.setAttribute("capture", front ? "user" : "environment");

    input.click();
  }
});