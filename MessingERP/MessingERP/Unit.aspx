<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMast.master" AutoEventWireup="true"
    CodeFile="Unit.aspx.cs" Inherits="Unit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentCSS" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHead" runat="Server">
    <title>Messing ERP | Unit</title>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPageHeader" runat="Server">
    <h1>
        Unit <small>Entry</small>
    </h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Home</a></li>
        <li class="active">Unit</li>
    </ol>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentBody" runat="Server">
    <div class="row">
        <!-- left column -->
        <div class="col-md-12">
            <div class="box box-primary">
                <div class="box-header">
                    <h3 class="box-title">
                        Quick Example</h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                <div class="box-body">
                    <div class="row">
                        <div class="col-md-3">
                            <div class="form-group">
                                <label>
                                    Text</label>
                                <input type="text" class="form-control" placeholder="Enter ...">
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="form-group">
                                <label>
                                    Text</label>
                                <input type="text" class="form-control" placeholder="Enter ...">
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="form-group">
                                <label>
                                    Text</label>
                                <input type="text" class="form-control" placeholder="Enter ...">
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="form-group">
                                <label>
                                    Text</label>
                                <input type="text" class="form-control" placeholder="Enter ...">
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /.box-body -->
                <div class="box-footer">
                    <button type="submit" class="btn btn-primary">
                        Submit</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentJS" runat="Server">
</asp:Content>
