function ShowHideDiv(DivId)
{
    if(document.all[DivId].style.display=='none'){ 
        document.all[DivId].style.display='';
    }
    else{ 
        document.all[DivId].style.display='none';
    }
    return 0;
}