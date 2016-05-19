<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/aspx/Views/Shared/Web.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
 <div class="demo-section k-content">
     <h4>Enter phone number</h4>
     <%= Html.Kendo().MaskedTextBox()
          .Name("maskedtextbox")
          .Mask("(999) 000-0000")
          .HtmlAttributes(new { style = "width: 100%" })
     %>
 </div>

<div class="box wide">
    <div class="box-col">
    <h4>Set / Get Value</h4>
    <ul class="options">
        <li>
            <button id="get" class="k-button">Get value</button>
        </li>
        <li>
            <button id="set" class="k-button">Set value</button>
            <input class="k-textbox" id="value" value="555 123 4567" style="float:none" />
        </li>
    </ul>
    </div>
    <div class="box-col">
    <h4>Enable / Disable</h4>
    <ul class="options">
        <li>
            <button id="enable" class="k-button">Enable</button>
            <button id="disable" class="k-button">Disable</button>
        </li>
        <li>
            <button id="readonly" class="k-button">Readonly</button>
        </li>
    </ul>
    </div>
</div>          

<script>
    $(document).ready(function () {
        var maskedtextbox = $("#maskedtextbox").data("kendoMaskedTextBox");

        var setValue = function () {
            maskedtextbox.value($("#value").val());
        };

        $("#enable").click(function () {
            maskedtextbox.enable();
        });

        $("#disable").click(function () {
            maskedtextbox.enable(false);
        });

        $("#readonly").click(function () {
            maskedtextbox.readonly();
        });

        $("#set").click(setValue);

        $("#get").click(function () {
            alert(maskedtextbox.value());
        });
    });
</script>           
<style>
    #value {
        width: 135px;
        margin-left: 3px;
    }
</style>
</asp:Content>