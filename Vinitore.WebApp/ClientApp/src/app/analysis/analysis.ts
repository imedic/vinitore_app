export interface AnalysisView {
    id: number;
    wineId: number;
    wineName: string;
    barrelId: number;
    barrelName: string;
    date: Date;
}

export interface AnalysisDetailView {
    id: number;
    wineId: number;
    wineName: string;
    barrelId: number;
    barrelName: string;
    date: Date;
    alcohol: number;
    acid: number;
    volatileAcid: number;
    totalDryExtract: number;
    totalSulphurDioxide: number;
    freeSulphurDioxide: number;
    ph: number;
}

export interface AnalysisCommand {
    wineId: number;
    barrelId: number;
    alcohol: number;
    acid: number;
    volatileAcid: number;
    totalDryExtract: number;
    totalSulphurDioxide: number;
    freeSulphurDioxide: number;
    ph: number;
}
