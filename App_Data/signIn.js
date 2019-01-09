
$.getJSON('http://localhost:7407/home/returnviev', function (data) {
    var content = '';
    content+="<tbody>";

    $.each(data, function (index, element) {

        content += "<tr>";
        content += "<td >";
        content += "<a style='text-overflow: ellipsis;' href=";
        content += element.Link;
        content += '">';
        content += element.Link.slice(0,35);
        content += "...";
        content += "</a>";
        content += "</td>";
        content += "<td>";
        content += element.PriceNow;
        content += "</td>";
        content += "<td>";
        content += element.DesiredPrice;
        content += "</td>";
        content += "</tr>";
    });
    content+="</tbody>";
    // $.getJSON('http://localhost:7407/home/returnviev', function(data) 
    // {
    //     // for (var i=101;i>100;i++)
    //     // {$.getJSON('http://localhost:7407/home/returnviev', function(data) 
    //     // {
    //     //     if (data)
    //     //     {
    //     //         alert(true);
    //     //     }
    //     // });
    //     //}
    // });
    if (localStorage.getItem('isLogged') == 'true') {
        $("body").replaceWith(`
<div style="height: 300px; width: 600px;">
<!-- <style type="text/css">
    .paper {

        width: 600px;
        height: 300px;
        /* background-color: #ef4444; */
        color: #666666;
    }
</style> -->
<div class="row">
    <div class="col-xs-2 light" style="color: rgb(248, 248, 248); text-shadow: blue 0 0 10px;">
        <b>Track</b>
    </div>
    <div class="col-xs-8 text-center">
        <div class="col-xs-3 text-center"></div>
        <div class="col-xs-6 text-center">vladimir.krestov@ispi.ru</div>
        <div class="col-xs-3 text-center">
            <button style="background-color: transparent; border: 0">
                <img src="src/SignOut.png" width="20" height="20" alt="SignOut">
            </button>
        </div>
    </div>
    <div class="col-xs-2 text-center">
        <button style="background-color: transparent; border: 0">
            <img src="src/Settings.png" width="20" height="20" alt="Settings">
        </button>
    </div>
</div>
<div class="row">
    <div class="col-xs-2 text-center" style="color: rgb(255, 255, 255); text-shadow: blue 0 0 10px;">
        <b>Price</b>
    </div>
</div>
<div class="text-center container-fluid">
    <p>
        <h4><b>Your products</b></h4>
    </p>
</div>
<div>
        <table class="table table-hover scrolling-table">
        <thead>
            <tr>
                <th>link</th>
                <th>Price</th>
                <th>Desired proce</th>
            </tr>
        </thead>
        <tbody>
        </tbody>
        </table>
    </div>

    <div class="row">
        <input class="col-xs-9" id="linkProduct" placeholder="Link">
        <input type="button" value="Add link" class="addlinkproduct col-xs-3" id="addLinkBut" placeholder="Link">
    </div>

</div>` );
        $("tbody").replaceWith(content);
    }



    $(document).ready(function () {

        $('input.addlinkproduct').click(function (event) {
            var link1 = document.getElementById('linkProduct').value;
            debugger;
            if(link1 != "")
            {
                var str = 'http://localhost:7407/home/todb?link='+link1;
                $.getJSON(str, function (data) {});
                update();
            }
        });
        $('button').click(function (event) {
            if (document.getElementById('exampleInputEmail1').value == "vk@ispu.ru" && document.getElementById('exampleInputPassword1').value == "123") {
                if (localStorage.getItem('isLogged') != 'false') {
                    localStorage.setItem('isLogged', 'true');
                }
                $("body").replaceWith(`
<div style="height: 300px; width: 600px;">
    <!-- <style type="text/css">
        .paper {

            width: 600px;
            height: 300px;
            /* background-color: #ef4444; */
            color: #666666;
        }
    </style> -->
    <div class="row">
        <div class="col-xs-2 light" style="color: rgb(248, 248, 248); text-shadow: blue 0 0 10px;">
            <b>Track</b>
        </div>
        <div class="col-xs-8 text-center">
            <div class="col-xs-3 text-center"></div>
            <div class="col-xs-6 text-center">vladimir.krestov@ispi.ru</div>
            <div class="col-xs-3 text-center">
                <button style="background-color: transparent; border: 0">
                    <img src="src/SignOut.png" width="20" height="20" alt="SignOut">
                </button>
            </div>
        </div>
        <div class="col-xs-2 text-center">
            <button style="background-color: transparent; border: 0">
                <img src="src/Settings.png" width="20" height="20" alt="Settings">
            </button>
        </div>
    </div>
    <div class="row">
        <div class="col-xs-2 text-center" style="color: rgb(255, 255, 255); text-shadow: blue 0 0 10px;">
            <b>Price</b>
        </div>
    </div>
    <div class="text-center container-fluid">
        <p>
            <h4><b>Your products</b></h4>
        </p>
    </div>
    <div>
        <table class="table table-hover scrolling-table">
        <thead>
            <tr>
                <th>link</th>
                <th>Price</th>
                <th>Desired proce</th>
            </tr>
        </thead>
        <tbody>
        </tbody>
        </table>
    </div>
    <div class="footer">
        <input class="form-control" id="linkProduct" placeholder="Link">
        <button type="submit" id="addLink" class="btn btn-primary btn-md center-block text-uppercase" style="width: 100px">
            Add link
        </button>w
    </div>
</div>` );
                $("tbody").replaceWith(content);
            }
            else {
                alert('sadoigfilsadufhgiouadshfiughadsiufgioaudsehfi');
            }
        });
    });
});

var update = function(){
    var content = '';
    debugger;
    $.getJSON('http://localhost:7407/home/returnviev', function (data){
    content+="<tbody>";

    $.each(data, function (index, element) {

        content += "<tr>";
        content += "<td >";
        content += "<a style='text-overflow: ellipsis;' href=";
        content += element.Link;
        content += '">';
        content += element.Link.slice(0,35);
        content += "...";
        content += "</a>";
        content += "</td>";
        content += "<td>";
        content += element.PriceNow;
        content += "</td>";
        content += "<td>";
        content += element.DesiredPrice;
        content += "</td>";
        content += "</tr>";
    });
    content+="</tbody>";
    if (localStorage.getItem('isLogged') == 'true') {
        $("body").replaceWith(`
    <div style="height: 300px; width: 600px;">
    <!-- <style type="text/css">
    .paper {
    
        width: 600px;
        height: 300px;
        /* background-color: #ef4444; */
        color: #666666;
    }
    </style> -->
    <div class="row">
    <div class="col-xs-2 light" style="color: rgb(248, 248, 248); text-shadow: blue 0 0 10px;">
        <b>Track</b>
    </div>
    <div class="col-xs-8 text-center">
        <div class="col-xs-3 text-center"></div>
        <div class="col-xs-6 text-center">vladimir.krestov@ispi.ru</div>
        <div class="col-xs-3 text-center">
            <button style="background-color: transparent; border: 0">
                <img src="src/SignOut.png" width="20" height="20" alt="SignOut">
            </button>
        </div>
    </div>
    <div class="col-xs-2 text-center">
        <button style="background-color: transparent; border: 0">
            <img src="src/Settings.png" width="20" height="20" alt="Settings">
        </button>
    </div>
    </div>
    <div class="row">
    <div class="col-xs-2 text-center" style="color: rgb(255, 255, 255); text-shadow: blue 0 0 10px;">
        <b>Price</b>
    </div>
    </div>
    <div class="text-center container-fluid">
    <p>
        <h4><b>Your products</b></h4>
    </p>
    </div>
    <div>
        <table class="table table-hover scrolling-table">
        <thead>
            <tr>
                <th>link</th>
                <th>Price</th>
                <th>Desired proce</th>
            </tr>
        </thead>
        <tbody>
        </tbody>
        </table>
    </div>
    
    <div class="row">
        <input class="col-xs-9" id="linkProduct" placeholder="Link">
        <input type="button" value="Add link" class="addlinkproduct col-xs-3" id="addLinkBut" placeholder="Link">
    </div>
    
    </div>` );
    debugger;
        $("tbody").replaceWith(content);
}
});
}