import { ComponentFixture, TestBed } from '@angular/core/testing';
import { AddMotoqueiroComponent } from '../add-motoqueiro.component';


describe('AddMotoqueiroComponent', () => {
  let component: AddMotoqueiroComponent;
  let fixture: ComponentFixture<AddMotoqueiroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AddMotoqueiroComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddMotoqueiroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
