//console.log("befor ready");
$(document).ready(function () {
   // console.log("before");
    $('#CatID').on('change', function () {
        console.log("change")
        var CategoryId = $(this).val();
        var propertyDivi = $('#properyDiv');
        propertyDivi.empty();
        console.log(CategoryId)
        if (CategoryId > 0 || CategoryId != '')
        {
            $.ajax({
                url: '/Home/GetProperty?catId=' + CategoryId,
                success: function (Properties) {
                    $.each(Properties, function (i, property) {
                        console.log(property.propId)

                     //   propertyDivi.append($('<label></label>')).attr('asp-for', property.name).text(property.name);
                        propertyDivi.append($('<br><label>' + property.name + '</label><br><input type="text" class="form-control" name="Values['+i+'].Values"> <input type="text" hidden name="Values['+i+'].propertyId" value="'+property.propId+'">').attr('id', property.name));
                       // propertyDivi.append($('<br>'));
                        
                    });
                },
                error: function () {
                    alert('Somtheng went Wrong!');
                },
            }); 
        }
    });
});