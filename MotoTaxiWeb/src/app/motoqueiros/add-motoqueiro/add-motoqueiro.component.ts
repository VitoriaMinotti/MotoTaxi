import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import {
  FormGroup,
  FormBuilder,
  Validators,
  ReactiveFormsModule,
} from '@angular/forms';
import { MatDialogModule, MatDialogRef } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MotoqueirosComponent } from '../motoqueiros.component';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatButtonModule } from '@angular/material/button';
import { MatNativeDateModule, MatOptionModule } from '@angular/material/core';
import { provideNgxMask, NgxMaskDirective } from 'ngx-mask';
import { MotoqueirosService } from '../motoqueiros.service';
import { MatSelectModule } from '@angular/material/select';

@Component({
  selector: 'app-add-motoqueiro',
  standalone: true,
  imports: [
    CommonModule,
    MatDialogModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatDatepickerModule,
    MatNativeDateModule,
    ReactiveFormsModule,
    NgxMaskDirective,
    MatOptionModule,
    MatSelectModule,
  ],
  providers: [provideNgxMask()],
  templateUrl: './add-motoqueiro.component.html',
})
export class AddMotoqueiroComponent {
  motoqueiroForm!: FormGroup;
  estadoCivilOptions = [
    'Solteiro(a)',
    'Casado(a)',
    'Divorciado(a)',
    'Viúvo(a)',
  ];

  constructor(
    private _motoqueirosService: MotoqueirosService,
    private dialogRef: MatDialogRef<MotoqueirosComponent>,
    private fb: FormBuilder
  ) {}

  ngOnInit(): void {
    this.motoqueiroForm = this.fb.group({
      nome: ['', Validators.required],
      apelido: ['', Validators.required],
      cpf: ['', Validators.required],
      rg: ['', Validators.required],
      dataNascimento: ['', Validators.required],
      telefone: ['', Validators.required],
      endereco: ['', Validators.required],
      estadoCivil: ['', Validators.required],
      telefoneEmergencia: ['', Validators.required],
    });
  }

  onSubmit() {
    if (this.motoqueiroForm.valid) {
      // Garantir que as datas sejam convertidas para o formato ISO 8601
      const formData = this.motoqueiroForm.value;

      // Verificar e converter as datas, se existirem
      if (formData.dataNascimento) {
        formData.dataNascimento = new Date(
          formData.dataNascimento
        ).toISOString();
      }
      if (formData.dataVencimentoCnh) {
        formData.dataVencimentoCnh = new Date(
          formData.dataVencimentoCnh
        ).toISOString();
      }
      if (formData.dataContratacao) {
        formData.dataContratacao = new Date(
          formData.dataContratacao
        ).toISOString();
      }
      if (formData.dataDesligamento) {
        formData.dataDesligamento = new Date(
          formData.dataDesligamento
        ).toISOString();
      }

      this._motoqueirosService.addMotoqueiro(formData).subscribe({
        next: (response) => {
          console.log('Motoqueiro adicionado com sucesso:', response);
          this.dialogRef.close(formData);
        },
        error: (error) => {
          console.error('Erro ao adicionar motoqueiro:', error);
        },
      });
    }
    this.dialogRef.close(this.motoqueiroForm.value);
  }

  onCancel() {
    this.dialogRef.close();
  }
}
