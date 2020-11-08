window.openAddIncomeModalElement = function () {
    var modal = document.querySelector("#addIncomeModal");
    modal.show();
}

window.openAddExpenseModalElement = function () {
    var modal = document.querySelector("#addExpenseModal");

    modal.show();
}

window.closeAddIncomeModalElement = function () {
    var modal = document.querySelector("#addIncomeModal");
    modal.close();
}

window.closeAddExpenseModalElement = function () {
    var modal = document.querySelector("#addExpenseModal");
    modal.close();
}

window.updateCounter = function (args) {
    var counter = document.querySelector(args[0]);
    counter.update(args[1]);
}
