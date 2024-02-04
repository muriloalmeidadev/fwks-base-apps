import { AfterViewInit, Directive, ElementRef, inject } from '@angular/core'

@Directive({
    selector: '[fwksCurrency]',
    standalone: true
})
export class CurrencyDirective implements AfterViewInit {

    elementRef = inject(ElementRef)

    ngAfterViewInit(): void {
        console.log(this.elementRef.nativeElement.innerText)
    }

}
