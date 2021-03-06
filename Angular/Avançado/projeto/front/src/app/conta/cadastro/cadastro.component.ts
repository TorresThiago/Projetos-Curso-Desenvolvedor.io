import { AfterViewInit, Component, ElementRef, OnInit, ViewChildren, Injectable  } from '@angular/core';
import { FormBuilder, FormGroup, Validators, FormControl, FormControlName } from '@angular/forms';
//import { CustomValidators } from 'ngx-custom-validators';
import { DisplayMessage, GenericValidator, ValidationMessages } from 'src/app/utils/generic-form-validation';
import { Usuario } from '../models/usuario';
import { ContaService } from '../services/conta.service';

import { CustomValidators } from '@narik/custom-validators';
import { fromEvent, merge, Observable } from 'rxjs';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html'
})
export class CadastroComponent implements OnInit, AfterViewInit {

  @ViewChildren(FormControlName, {read: ElementRef }) formInputElements: ElementRef[];

  

  errors: any[] = [];
  cadastroForm: FormGroup;
  usuario: Usuario;

  validationMessages: ValidationMessages;
  genericValidator: GenericValidator;
  displayMessage: DisplayMessage = {};

  constructor(private fb: FormBuilder, private contaService: ContaService, private router: Router) { 

   
    this.validationMessages = {
      email: {
        required: 'Informe o e-mail',
        email: 'E-mail inválido',
      },
      password: {
        required: 'Informe a senha',
        rangeLength: 'A senha deve possuir entre 6 e 15 caracteres'
      },
      confirmPassword: {
        required: 'Informe a senha novamente',
        rangeLength: 'A senha deve possuir entre 6 e 15 caracteres',
        equalTo: 'As senhas não conferem'
      }
    };
    this.genericValidator = new GenericValidator(this.validationMessages);
   }

  ngOnInit(): void {

    let senha = new FormControl('', [Validators.required, CustomValidators.rangeLength([6, 15])]);
    let senhaConfirm = new FormControl('', [Validators.required, CustomValidators.rangeLength([6, 15]), CustomValidators.equalTo(senha)]);


    this.cadastroForm = this.fb.group({
      email: ['',[Validators.required, Validators.email]],
      password: senha,
      confirmPassword: senhaConfirm
    });
  }


  ngAfterViewInit(): void {
        let controlBlurs: Observable<any>[] = this.formInputElements
           .map((formControl: ElementRef) => fromEvent(formControl.nativeElement, 'blur'));

        merge(...controlBlurs).subscribe(() =>{
          this.displayMessage = this.genericValidator.processarMensagens(this.cadastroForm);
        });
  }

  adicionarConta(){
    if(this.cadastroForm.dirty && this.cadastroForm.valid){
      this.usuario = Object.assign({},this.usuario, this.cadastroForm.value);

      this.contaService.registrarUsuario(this.usuario).subscribe(
        sucesso => {this.processarSucesso(sucesso)},
        falha => {this.processarFalha(falha)}
      );
    }
  }

  processarSucesso(response: any){
    this.cadastroForm.reset();
    this.errors = [];

    this.contaService.LocalStorage.salvarDadosLocaisUsuario(response);

    this.router.navigate(['/home']);
  }

  processarFalha(fail: any){
    this.errors = fail.error.errors;

  }

}
