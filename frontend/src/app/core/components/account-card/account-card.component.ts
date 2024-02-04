import { Component, Input } from '@angular/core'
import { RouterLink } from '@angular/router'

@Component({
    selector: 'fwks-account-card',
    standalone: true,
    imports: [
        RouterLink
    ],
    templateUrl: './account-card.component.html',
    styles: ''
})
export class AccountCardComponent {

    @Input() url: string | undefined
    @Input() class = ''
    @Input() color = '#7f8c8d'
    @Input() icon = 'fi-rr-layout-fluid'
    @Input() title: string | number | Date | undefined | null
    @Input() value: string | number | Date | undefined | null

}
