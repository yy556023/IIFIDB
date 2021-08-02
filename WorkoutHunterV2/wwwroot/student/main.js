 //裝備藥水:實現藥水單向(若裝備欄內沒藥水可直接裝備)、雙向置換(若裝備欄內已經有藥水，直接點擊新藥水會進行置換)，

var x = document.getElementsByClassName('rpgui-icon empty-slot')
for (let i = 0; i < x.length; i++) {
        x[i].addEventListener("click",function(){
            var Data = document.getElementById('potion_col')
                if(Data.firstElementChild!=null){
                    var x_copy = x[i].firstElementChild
                    var x_copy = x[i].firstElementChild
                    x_copy.style['height']='100%';
                    x_copy.style['width']='100%';
                    x[i].firstElementChild.remove();
                    Data.firstElementChild.style['height']='100%';
                    Data.firstElementChild.style['width']='100%';
                    x[i].append(Data.firstElementChild)
                    Data.append(x_copy);
                }
                else{
                    var x_copy = x[i].firstElementChild
                    var x_copy = x[i].firstElementChild
                    x[i].firstElementChild.remove();
                    x_copy.style['height']='100%';
                    x_copy.style['width']='100%';
                    Data.append(x_copy);
                }
        })
}

//解除藥水:可透過點擊下方藥水裝備欄返回藥水回倉庫，會自動找空格填入

var y = document.getElementById('potion_col')
 y.addEventListener("click",function(){
     var y_copy=y.firstChild
     y_copy.style['height']='100%';
     y_copy.style['width']='100%';
     var Data = document.getElementsByClassName('rpgui-icon empty-slot')
     for(var i=0; i<=29;i++){
         if (Data[i].firstElementChild==null){
            Data[i].append(y_copy);
            break;
         }
     }
 })