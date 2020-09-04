// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(() => {
    if ( $("#statiePlecare") ) {
        $('.buton-submit').on('click', () => {
            let statiePlecare = $("#statiePlecare").val();
            let statieSosire = $("#statieSosire").val();

            $.ajax({
                type: 'GET',
                url: location.href + 'home/AlegereRuta',
                data: { statiePlecare, statieSosire },
                success: () => {
                    window.location = location.href + 'home/AlegereRuta?statiePlecare=' + statiePlecare + '&statieSosire=' + statieSosire;
                }
            });

        })

        $('.buton-cauta').on('click', () => {
            let cautareId = $("#cautareId").val();

            $.ajax({
                type: 'GET',
                url: location.href,
                data: { cautareId },
                success: () => {
                    window.location = location.href + 'home/RezervareEditare?cautareId=' + cautareId;
                }
            });

        })
    }

    $('#anulare-comanda').on('click', () => {
        let id = $('#id-comanda').val();
        let raspuns = confirm(`Esti sigur ca vrei sa anulezi rezervarea nr. ${id}?`);
        if (raspuns) {
            $.ajax({
                type: 'DELETE',
                url: '/home/StergereComanda',
                data: { id },
                success: () => {
                    window.location = '/home/RezultatComanda/id=' + id;
                    //window.location = location.origin + '/home/RezultatComanda';
                }
            });
        } else {
            window.location = location.href;
            alert('Ai renuntat la stergerea comenzii. Aceasta a ramas activa');
        }
    })

    if ( $("#datepicker").length ) {
        $(function () {
            $("#datepicker").datepicker({ dateFormat: "dd/mm/yy", minDate: new Date() });
            $("#datepicker").datepicker("show");
            });
        }
    }
);
