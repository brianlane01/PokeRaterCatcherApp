// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function fetchPokemonDescriptionById(searchText) {
    let pokemonDescription = document.getElementById("pokemonDescription");
    fetch(`https://pokeapi.co/api/v2/pokemon-species/${searchText}`)
        .then(function (response) {
            console.log(response);
            return response.json();
        })
        .then(function (json) {
            console.log(json);
            let pokeDescription = json.flavor_text_entries[6].flavor_text;
            let pItem = document.createElement('p');
            pItem.innerText = pokeDescription;
            pokemonDescription.appendChild(pItem);
        })
        .catch(function (error) {
            console.error('Error:', error);
        });
}
fetchPokemonDescriptionById("@searchText");
