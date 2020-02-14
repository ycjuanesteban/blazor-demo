function showAlert() {
    alert("Ping!");
}

function showQuestion(question) {
    return prompt(question);
}

function setElementById(id, text) {
    document.getElementById(id).innerText = text;
}

function setFocus(element)
{
    element.focus();
}

function callDotNetMethod() {
    alert('In');
    DotNet.invokeMethodAsync('ServerBlazor', 'GenerateRandomInt')
        .then((result) => {
            setElementById('random-span', result);
        })
}