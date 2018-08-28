export interface Wine {
    name: string;
    year: number;
    type: WineType;
}

export enum WineType {
    Dry = 0,
    MediumDry,
    MediumSweet,
    Sweet
}