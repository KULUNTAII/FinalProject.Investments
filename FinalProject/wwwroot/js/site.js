document.addEventListener("DOMContentLoaded", function () {
    var links = document.querySelectorAll("a");

    links.forEach(function (link) {
        link.addEventListener("click", function (event) {
            // Проверяем, что не нажата ссылка "My projects"
            if (!link.id || link.id !== "myProjectsLink") {
                event.preventDefault();

                // Добавляем анимацию затушевания для плавного перехода
                document.body.style.transition = "opacity 0.5s ease-in-out";
                document.body.style.opacity = 0;

                var nextPage = link.getAttribute("href");

                setTimeout(function () {
                    window.location.href = nextPage;
                }, 500);
            }
        });
    });
});
