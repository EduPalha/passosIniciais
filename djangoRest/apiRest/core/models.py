# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models

class Cliente(models.Model):
    nome = models.CharField(max_length=80)
    endereco = models.CharField(max_length=100)
    idade = models.IntegerField()

def __str__(self):
    return self.nome
