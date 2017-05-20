CREATE TABLE [dbo].[EmailListPartners] (
    [EmailLists_EmailListID] INT NOT NULL,
    [Partners_PartnerID]     INT NOT NULL,
    CONSTRAINT [FK_EmailListPartners_EmailLists] FOREIGN KEY ([EmailLists_EmailListID]) REFERENCES [dbo].[EmailLists] ([EmailListID]) ON DELETE CASCADE,
    CONSTRAINT [FK_EmailListPartners_Partners] FOREIGN KEY ([Partners_PartnerID]) REFERENCES [dbo].[Partners] ([PartnerID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_EmailListPartners_Partners]
    ON [dbo].[EmailListPartners]([Partners_PartnerID] ASC);

