const { data } = require("jquery");


var inp;
var dvOut;
var dv;
  
// 註冊新成員(左方產生按鈕)       
  function addStudentBtn_confirm(e) {
    var students = document.querySelectorAll(".student");
    var turnOff = false;
    // for(var i = 0; i < students.length; i++){
    //    turnOff = students[i].querySelector("button").innerText == document.querySelector("#NewStName").value;
    //    if(turnOff)
    //       break;
    // }

    // 產生新成員按鈕-------------------------完成
    if(!turnOff){
      //傳入點選按鈕的value值到新的按鈕
      inp = document.createElement("button");
      inp.className = "tablinks";
      var NewStudentName;
      NewStudentName = document.querySelector("#NewStName").value;
      inp.innerHTML = 
      `${NewStudentName}    <input type='button' onclick='deleteDepartment(this)' value='刪除'>`
      var stList = document.querySelector('.students') // li外面包的div
      var li = document.createElement('li') 
      li.className ="student"
      stList.appendChild(li)
      //傳入點選按鈕的id

      let r = `li_${students.length}`;
      li.id = r;
      
      li.appendChild(inp);
      allinp = inp

      //-------------------------產生新學員姓名框 ok
      
      x = document.createElement('div');
      s = document.querySelectorAll('.studentContent');
      if(x.id==""){
        x.id = `student${s.length}`;
        // x = document.createElement('div');   // x 是產生新學員姓名框
        x.value = document.querySelector("#NewStName").value;
        x.innerHTML = document.querySelector("#NewStName").value;
        x.textContent = document.querySelector("#NewStName").value;
        x.style.display = 'none'; // 還沒被點到，隱藏
        x.className = "studentContent";
        var stNamediv = document.querySelector('.StudentsNameStorehouse'); // x外面的div
        stNamediv.appendChild(x);  // 產出 學員方框文字
      }
      // --------------------------- 產生學員圖片 ok
      imgy = document.createElement("img");
      imgy = document.getElementById('zeroStudent');
      imgy.type = "image";
      var imgdiv = document.querySelector('.OutstudentImg');
      dvOut = document.createElement("div");     // imgdiv        >     dvOut    >  dv ---          imgy
      dvOut.className = 'studentImg';                //(OutstudentImg)> (studengImg) > (student_x_Img)  >
      var dv = document.createElement("div");
      dv.className = "student_x_Img";
      dv.value = imgy;
      imgdiv.appendChild(dvOut);
      dvOut.appendChild(dv)
      dv.appendChild(imgy)     
      dvOut.style.display = 'none' // 還沒被點到，先隱藏

      // ------------------------------ 點擊按鈕
      console.log(inp);
      inp.onclick = function(){
        LeftBtnShowData(this);
      }
   
    }else{
      alert('已存在')
    }
  }
    
    function LeftBtnShowData(e) {       // 新學員按鈕的點擊事件
      var LeftStudent = document.querySelectorAll(".student");
      var Number = 0;
      for(var j = 0; j < LeftStudent.length; j++){
          if(LeftStudent[j] == e.parentNode){
            Number = j;
            break;
          }
      }
      var StudentName = document.querySelector(`#student${Number}`);
      var i ,studentContent,studentImg, tablinks;
      studentContent = document.getElementsByClassName("studentContent"); //學員姓名div
      for(i = 0; i < studentContent.length; i++){
          studentContent[i].style.display = "none";
      }
      studentImg = document.getElementsByClassName("studentImg"); // 學員圖片
      for(i = 0; i < studentImg.length; i++ ){
          studentImg[i].style.display = "none";
      }
      tablinks = document.getElementsByClassName("tablinks"); // 學員按鈕
      for (i = 0; i < tablinks.length; i++) {
          tablinks[i].className = tablinks[i].className.replace(" active", "");
      }
      
      StudentName.style.display = 'block';
      dvOut.style.display = 'block';
      inp.className += " active";      
    }
    //Get the element with id="defaultOpen" and click on it
    document.getElementById("defaultOpen").click();

    
   


		

  
 



