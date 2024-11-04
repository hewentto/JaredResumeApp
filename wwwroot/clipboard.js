
window.copyToClipboard = (text) => {
    navigator.clipboard.writeText(text)
        .then(() => console.log("Text copied to clipboard"))
        .catch(err => console.error("Could not copy text: ", err));
};

window.addFadeOutClass = (element) => {
    element.classList.add("fade-out");
};


document.addEventListener('DOMContentLoaded', function () {
    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
    var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
        return new bootstrap.Tooltip(tooltipTriggerEl);
    });
});

window.techStackModal = {
    show: function () {
        var modalElement = document.getElementById('techStackModal');
        var modal = new bootstrap.Modal(modalElement);
        modal.show();
    },
    hide: function () {
        var modalElement = document.getElementById('techStackModal');
        var modalInstance = bootstrap.Modal.getInstance(modalElement);
        if (modalInstance) {
            modalInstance.hide();
        }
    }
}