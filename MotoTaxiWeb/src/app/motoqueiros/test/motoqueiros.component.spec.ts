import { ComponentFixture, TestBed } from '@angular/core/testing';
import { MotoqueirosComponent } from '../motoqueiros.component';


describe('MotoqueirosComponent', () => {
  let component: MotoqueirosComponent;
  let fixture: ComponentFixture<MotoqueirosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MotoqueirosComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MotoqueirosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
