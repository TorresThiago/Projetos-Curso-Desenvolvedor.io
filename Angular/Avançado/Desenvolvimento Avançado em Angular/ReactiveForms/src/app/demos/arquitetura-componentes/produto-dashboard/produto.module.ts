import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProdutoDashboardComponent } from './produto-dashboard.component';
import { ProdutoRoutingModule } from './produto.route';

@NgModule({
declarations:[
    ProdutoDashboardComponent
],
imports:[
    CommonModule,
    ProdutoRoutingModule
],
exports: []
})
export class ProdutosModule{}