export interface Wine {
    name: string;
    year: number;
    type: WineType;
}

export interface WineDetails {
    id: number;
    name: string;
    type: WineType;
}

export interface WineSummary {
    id: number;
    name: string;
}

export enum WineType {
    Dry = 0,
    MediumDry,
    MediumSweet,
    Sweet
}